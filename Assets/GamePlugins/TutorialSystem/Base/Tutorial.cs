using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using GamePlugins.TutorialSystem.Conditions;

namespace GamePlugins.TutorialSystem.Base
{
    /// <summary>
    /// Базовый класс туториала
    /// </summary>
    public class Tutorial : ITutorial
    {
        public event Action<ITutorial> onCompleteTutorial = delegate { };

        public event Action<ITutorial> onStartTutorial = delegate { };

        public event Action<StepTutorial> onStartStepTutorial = delegate { };

        public event Action<StepTutorial> onEndStepTutorial = delegate { };

        /// <summary>
        /// Условие необходимое для запуска туториала
        /// </summary>
        public AbstractCondition Condition => condition;

        /// <summary>
        /// Доступные шаги туториала
        /// </summary>
        public List<StepTutorial> StepTutorial => stepTutorial;

        protected AbstractCondition condition;

        protected List<StepTutorial> stepTutorial;

        private StepTutorial currentAbstractSubStep;

        public Tutorial(List<StepTutorial> AbstractSubStep, AbstractCondition abstractCondition)
        {
            stepTutorial = AbstractSubStep;
            condition = abstractCondition;
        }

        async void ITutorial.StartTutorial()
        {
            await UniTask.DelayFrame(1);
            NextStepTutorial();
            onStartTutorial.Invoke(this);
        }


        protected void NextStepTutorial()
        {
            ReleasePreviousStepTutorial();
            TryStartStepTutorial();
        }

        protected virtual void ReleasePreviousStepTutorial()
        {
            if (currentAbstractSubStep != null)
            {
                currentAbstractSubStep.HasCompleted = true;
                currentAbstractSubStep.TutorialAction.onCompleteAction -= NextStepTutorial;
                onEndStepTutorial.Invoke(currentAbstractSubStep);
            }
        }

        protected virtual void TryStartStepTutorial()
        {
            currentAbstractSubStep = stepTutorial.FirstOrDefault(substep => !substep.HasCompleted);

            if (currentAbstractSubStep != null)
            {
                currentAbstractSubStep.TutorialAction.StartAction();
                currentAbstractSubStep.TutorialAction.onCompleteAction += NextStepTutorial;
                onStartStepTutorial.Invoke(currentAbstractSubStep);
            }
            else
            {
                ((ITutorial)this).CompleteTutorial();
                return;
            }
        }

        void ITutorial.CompleteTutorial()
        {
            stepTutorial.ForEach(x => x.TutorialAction.onCompleteAction -= NextStepTutorial);
            onCompleteTutorial.Invoke(this);
        }
    }
}
