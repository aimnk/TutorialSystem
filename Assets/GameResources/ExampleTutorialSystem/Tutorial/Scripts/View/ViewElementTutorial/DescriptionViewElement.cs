using GamePlugins.TutorialSystem.Base;
using GamePlugins.TutorialSystem.View;
using GameResources.ExampleTutorialSystem.View;
using UnityEngine;

namespace GameResources.ExampleTutorialSystem.Tutorial.ViewElementTutorial
{
    /// <summary>
    /// Отображение информации
    /// </summary>
    [CreateAssetMenu(fileName = nameof(DescriptionViewElement), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(DescriptionViewElement))]
    public class DescriptionViewElement : AbstractViewTutorialElement
    {
        public override void ShowElement(StepTutorial stepTutorial)
        {
            if (InitElement == null)
            {
                return;
            }

            if (!InitElement.TryGetComponent<ViewDescription>(out ViewDescription viewDescription))
            {
                return;
            }

            viewDescription.ShowDescriptions(stepTutorial.ViewTutorialData);
            viewDescription.transform.SetAsLastSibling();
        }
    }
}
