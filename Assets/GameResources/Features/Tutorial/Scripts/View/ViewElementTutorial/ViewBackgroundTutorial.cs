using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ����������� ���������� ���������
/// </summary>
[CreateAssetMenu(fileName = nameof(ViewBackgroundTutorial), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(ViewBackgroundTutorial))]
public class ViewBackgroundTutorial : AbstractViewTutorialElement
{
    [SerializeField]
    private Color32 color;

    public override void ShowElement(StepTutorial stepTutorial)
    {
        if (initElement != null)
        {
            initElement.GetComponent<Image>().color = color;
        }
    }
}
