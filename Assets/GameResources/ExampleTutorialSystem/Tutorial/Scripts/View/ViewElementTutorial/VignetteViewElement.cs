using Coffee.UIExtensions;
using GamePlugins.TutorialSystem.Base;
using GamePlugins.TutorialSystem.View;
using UnityEngine;

namespace GameResources.ExampleTutorialSystem.Tutorial.ViewElementTutorial
{
    /// <summary>
    /// Элемент визуалиции виньеттки
    /// </summary>
    [CreateAssetMenu(fileName = nameof(VignetteViewElement), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(VignetteViewElement))]
    public class VignetteViewElement : AbstractViewTutorialElement
    {
        public override void ShowElement(StepTutorial stepTutorial)
        {
            if (InitElement == null)
            {
                return;
            }

            InitElement.GetComponentInChildren<Unmask>().transform.position = stepTutorial.TutorialAction.transform.position;
        }
    }
}
