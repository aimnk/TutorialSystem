using Coffee.UIExtensions;
using UnityEngine;

/// <summary>
/// Элемент визуалиции виньеттки
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
