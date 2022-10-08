using UnityEngine;

/// <summary>
/// Отображение визаулизации туториала
/// </summary>
public class TutorialView : MonoBehaviour
{
    [SerializeField]
    private TutorialController tutorialController;

    [SerializeField]
    private TutorialHandler tutorialHandler;

    [SerializeField]
    private Transform content;

    private StepTutorial currentStepTutorial;

    private void OnEnable()
    {
       tutorialHandler.onStartStepTutorial += VisualizeStep;
       tutorialHandler.onEndStepTutorial += OnEndStepTutorial;
    }

    private void OnDisable()
    {
        tutorialHandler.onStartStepTutorial -= VisualizeStep;
        tutorialHandler.onEndStepTutorial -= OnEndStepTutorial;
    }

    /// <summary>
    /// Отобразить шаг туториала
    /// </summary>
    /// <param name="stepTutorial"></param>
    private void VisualizeStep (StepTutorial stepTutorial)
    {

        currentStepTutorial = stepTutorial;
        foreach (var item in stepTutorial.viewTutorialData.ViewTutorialElements)
        {
            item.InitViewElement(content);
            item.ShowElement(stepTutorial);
        }

        EnablerVizualization(currentStepTutorial, true);
    }

    private void OnEndStepTutorial(StepTutorial stepTutorial) => EnablerVizualization(stepTutorial, false);

    private void EnablerVizualization(StepTutorial stepTutorial, bool state)
    {
        foreach (var viewTutorialElement in stepTutorial.viewTutorialData.ViewTutorialElements)
        {
            viewTutorialElement.HideViewElementView(state);
        }
    }
}
