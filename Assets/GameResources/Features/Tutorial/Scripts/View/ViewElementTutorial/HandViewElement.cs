using UnityEngine;

/// <summary>
/// Элемент визузалиции руки
/// </summary>
[CreateAssetMenu(fileName = nameof(HandViewElement), menuName = "Tutorial/ViewTutorialElement/Create/" + nameof(HandViewElement))]
public class HandViewElement : AbstractViewTutorialElement
{
    private Canvas canvas;

    public override void ShowElement(StepTutorial stepTutorial)
    {
        if (initElement == null)
        {
            return;
        }

        if (canvas == null)
        {
            canvas = stepTutorial.TutorialAction.gameObject.GetComponentInParent<Canvas>();
        }

        var sizeObject = stepTutorial.TutorialAction.gameObject.GetComponent<RectTransform>().rect.size * canvas.scaleFactor;

        initElement.transform.position = new Vector3(
           stepTutorial.TutorialAction.gameObject.transform.position.x - sizeObject.x,
           stepTutorial.TutorialAction.gameObject.transform.position.y,
           stepTutorial.TutorialAction.gameObject.transform.position.z);
    }
}
