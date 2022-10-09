using GamePlugins.TutorialSystem.Base;
using GamePlugins.TutorialSystem.View;
using UnityEngine;
using UnityEngine.UI;

namespace GameResources.ExampleTutorialSystem.ViewElementTutorial
{
    [CreateAssetMenu(fileName = nameof(ViewBackgroundTutorial), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(ViewBackgroundTutorial))]
    public class ViewBackgroundTutorial : AbstractViewTutorialElement
    {
        [SerializeField]
        private Color32 color;

        public override void ShowElement(StepTutorial stepTutorial)
        {
            if (InitElement != null)
            {
                InitElement.GetComponent<Image>().color = color;
            }
        }
    }
}
