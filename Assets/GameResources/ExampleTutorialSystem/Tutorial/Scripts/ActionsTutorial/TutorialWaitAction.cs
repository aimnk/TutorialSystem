using Cysharp.Threading.Tasks;
using GamePlugins.TutorialSystem.TutorialActions;
using UnityEngine;

namespace GameResources.ExampleTutorialSystem.ActionTutorial
{
    /// <summary>
    /// Ожидание определенного времени для завершения шага туториала
    /// </summary>
    public class TutorialWaitAction : AbstractTutorialAction
    {
        [SerializeField]
        private int timeDelay = 5;

        public override async void StartAction()
        {
            await UniTask.Delay(timeDelay * 1000);
            EndAction();
        }

    }
}
