using System;

/// <summary>
/// Дата шага туториала
/// </summary>
[Serializable]
public class StepTutorial
{
    /// <summary>
    /// Дата визаулизации шага туториала
    /// </summary>
    public ViewTutorialData ViewTutorialData;

    /// <summary>
    /// Действие необходимое для выполнения шага туториала
    /// </summary>
    public AbtractTutorialAction TutorialAction;

    /// <summary>
    /// Шаг туториала завершен
    /// </summary>
    [NonSerialized]
    public bool HasCompleted;
}
