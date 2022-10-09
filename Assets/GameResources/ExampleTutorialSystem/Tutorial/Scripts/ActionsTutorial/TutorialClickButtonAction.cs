using GamePlugins.TutorialSystem.TutorialActions;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace GameResources.ExampleTutorialSystem.ActionTutorial
{
    /// <summary>
    /// Действие клик по кнопке для завершения шага туториала
    /// </summary>
    [RequireComponent(typeof(Button))]
    public class TutorialClickButtonAction : AbstractTutorialAction
    {
       [SerializeField]
        private int neededCountClick = 1;

        private int countClick;

        private Button button;

        public override void StartAction() => button.onClick.AddListener(OnButtonClicked);

        private void Awake() => button = GetComponent<Button>();

        private void OnButtonClicked()
        {
            countClick++;

            if (countClick >= neededCountClick)
            {
                button.onClick.RemoveListener(OnButtonClicked);
                EndAction();
            }
        }    
    }
}
