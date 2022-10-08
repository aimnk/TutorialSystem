using Coffee.UIExtensions;
using UnityEngine;

/// <summary>
/// Отображение виньетки
/// </summary>
[CreateAssetMenu(fileName = nameof(VignetteViewElement), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(VignetteViewElement))]
public class VignetteViewElement : AbstractViewTutorialElement
{
    public override void ShowElement(StepTutorial stepTutorial)
    {
        if (initElement == null)
        {
            return;
        }

        initElement.GetComponentInChildren<Unmask>().transform.position = stepTutorial.TutorialAction.transform.position;
    }
}
