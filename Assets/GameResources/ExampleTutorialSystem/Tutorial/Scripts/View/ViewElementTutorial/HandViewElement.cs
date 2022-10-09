using GamePlugins.TutorialSystem.Base;
using GamePlugins.TutorialSystem.View;
using UnityEngine;

namespace GameResources.ExampleTutorialSystem.ViewElementTutorial
{
    /// <summary>
    /// Элемент визузалиции руки
    /// </summary>
    [CreateAssetMenu(fileName = nameof(HandViewElement), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(HandViewElement))]
    public class HandViewElement : AbstractViewTutorialElement
    {
        private Canvas canvas;

        public override void ShowElement(StepTutorial stepTutorial)
        {
            if (InitElement == null)
            {
                return;
            }

            if (canvas == null)
            {
                canvas = stepTutorial.TutorialAction.gameObject.GetComponentInParent<Canvas>();
            }

            var sizeObject = stepTutorial.TutorialAction.gameObject.GetComponent<RectTransform>().rect.size * canvas.scaleFactor;

            var position = stepTutorial.TutorialAction.gameObject.transform.position;
        
            InitElement.transform.position = new Vector3(
                position.x - sizeObject.x,
                position.y,
                position.z);
        }
    }
}
