using UnityEngine;

/// <summary>
/// Отображение визаулизации туториала
/// </summary>
public class TutorialView : MonoBehaviour
{
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
        foreach (var item in stepTutorial.ViewTutorialData.ViewTutorialElements)
        {
            item.InitViewElement(content);
            item.ShowElement(stepTutorial);
        }

        EnablerVizualization(currentStepTutorial, true);
    }

    private void OnEndStepTutorial(StepTutorial stepTutorial) => EnablerVizualization(stepTutorial, false);

    private void EnablerVizualization(StepTutorial stepTutorial, bool state)
    {
        foreach (var viewTutorialElement in stepTutorial.ViewTutorialData.ViewTutorialElements)
        {
            viewTutorialElement.HideViewElementView(state);
        }
    }
}
