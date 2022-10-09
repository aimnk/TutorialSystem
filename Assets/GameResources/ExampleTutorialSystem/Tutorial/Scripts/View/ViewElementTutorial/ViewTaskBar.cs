using GamePlugins.TutorialSystem.Base;
using GamePlugins.TutorialSystem.View;
using UnityEngine;

namespace GameResources.ExampleTutorialSystem.ViewElementTutorial
{
    /// <summary>
    /// Отображение панели задач
    /// </summary>
    [CreateAssetMenu(fileName = nameof(ViewTaskBar), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(ViewTaskBar))]
    public class ViewTaskBar : AbstractViewTutorialElement
    {
        public override void ShowElement(StepTutorial stepTutorial)
        {
            if (InitElement == null)
            {
                return;
            }

            InitElement.transform.SetParent(stepTutorial.TutorialAction.gameObject.transform);
            InitElement.transform.localPosition = Vector3.zero;
        }
    }
}
