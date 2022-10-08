using System;
using UnityEngine;

/// <summary>
/// ���������� ������� ��������� (message bus)
/// </summary>
public class TutorialHandler : MonoBehaviour
{
    /// <summary>
    /// ������� - ������ ���������
    /// </summary>
    public event Action<Tutorial> onStartTutorial = delegate { };

    /// <summary>
    /// ������� - �������� ��������
    /// </summary>
    public event Action<Tutorial> onCompleteTutorial = delegate { };

    /// <summary>
    /// ������� - ������ ���� ���������
    /// </summary>
    public event Action<StepTutorial> onStartStepTutorial = delegate { };

    /// <summary>
    /// ������� - ��� ��������� ��������
    /// </summary>
    public event Action<StepTutorial> onEndStepTutorial = delegate { };

    [SerializeField]
    private TutorialController tutorialController;

    private void Awake() => tutorialController.OnInit += Init;

    private void Init()
    {
        foreach (var tutorial in tutorialController.Tutorials)
        {
            tutorial.onCompleteTutorial += OnCompleteTutorial;
            tutorial.onStartTutorial += OnStartTutorial;
            (tutorial as Tutorial).onStartStepTutorial += OnStartStepTutorial;
            (tutorial as Tutorial).onEndStepTutorial += OnEndStepTutorial;
        }
    }

    private void OnCompleteTutorial(ITutorial tutorial) => onCompleteTutorial.Invoke(tutorial as Tutorial);

    private void OnStartTutorial(ITutorial tutorial) => onStartTutorial.Invoke(tutorial as Tutorial);

    private void OnStartStepTutorial(StepTutorial stepTutorial) => onStartStepTutorial.Invoke(stepTutorial);

    private void OnEndStepTutorial(StepTutorial stepTutorial) => onEndStepTutorial.Invoke(stepTutorial);

    private void OnDestroy()
    {
        tutorialController.OnInit -= Init;

        foreach (var tutorial in tutorialController.Tutorials)
        {
            tutorial.onCompleteTutorial -= OnCompleteTutorial;
            tutorial.onStartTutorial -= OnStartTutorial;
            (tutorial as Tutorial).onStartStepTutorial -= OnStartStepTutorial;
        }
    }
}
