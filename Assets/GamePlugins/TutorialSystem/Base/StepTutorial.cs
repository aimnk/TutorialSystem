using System;
using GamePlugins.TutorialSystem.TutorialActions;
using GamePlugins.TutorialSystem.View.Data;

namespace GamePlugins.TutorialSystem.Base
{
    /// <summary>
    /// Дата шага туториала
    /// </summary>
    [Serializable]
    public class StepTutorial
    {
        /// <summary>
        /// Дата визаулизации шага туториала
        /// </summary>
        public ViewTutorialData ViewTutorialData;

        /// <summary>
        /// Действие необходимое для выполнения шага туториала
        /// </summary>
        public AbstractTutorialAction TutorialAction;

        /// <summary>
        /// Шаг туториала завершен
        /// </summary>
        [NonSerialized]
        public bool HasCompleted;
    }
}
