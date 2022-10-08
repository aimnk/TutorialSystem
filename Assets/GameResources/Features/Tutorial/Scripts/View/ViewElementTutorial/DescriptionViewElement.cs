using UnityEngine;

/// <summary>
/// ����������� �������� ���� ���������
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
            viewDescription.ShowDescriptions(stepTutorial.viewTutorialData);
            viewDescription.transform.SetAsLastSibling();
        }
    }
}
