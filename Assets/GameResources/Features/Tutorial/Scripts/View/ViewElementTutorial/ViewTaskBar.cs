using UnityEngine;

/// <summary>
/// Отображение таска бара
/// </summary>
[CreateAssetMenu(fileName = nameof(ViewTaskBar), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(ViewTaskBar))]
public class ViewTaskBar : AbstractViewTutorialElement
{
    public override void ShowElement(StepTutorial stepTutorial)
    {
        if (initElement != null)
        {
            initElement.transform.SetParent(stepTutorial.TutorialAction.gameObject.transform);
            initElement.transform.localPosition = Vector3.zero;
        }
    }
}
