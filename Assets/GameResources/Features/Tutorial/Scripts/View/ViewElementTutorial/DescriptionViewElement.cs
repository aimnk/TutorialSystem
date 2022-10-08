using UnityEngine;

/// <summary>
/// Отображение информации
/// </summary>
[CreateAssetMenu(fileName = nameof(DescriptionViewElement), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(DescriptionViewElement))]
public class DescriptionViewElement : AbstractViewTutorialElement
{
    public override void ShowElement(StepTutorial stepTutorial)
    {
        if (initElement == null)
        {
            return;
        }

        if (initElement.TryGetComponent<ViewDescription>(out ViewDescription viewDescription))
        {
            viewDescription.ShowDescriptions(stepTutorial.ViewTutorialData);
            viewDescription.transform.SetAsLastSibling();
        }
    }
}
