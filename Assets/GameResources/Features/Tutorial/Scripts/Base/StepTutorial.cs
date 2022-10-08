using System;
using UnityEngine;

/// <summary>
/// Дата для шага туториала
/// </summary>
[Serializable]
public class StepTutorial
{
    /// <summary>
    /// Дата визаулизации туториала
    /// </summary>
    public ViewTutorialData viewTutorialData;

    /// <summary>
    /// Действие необходимо для следующего шага туториала
    /// </summary>
    public AbtractTutorialAction TutorialAction;

    /// <summary>
    /// Завершен ли шаг туториала?
    /// </summary>
    public bool hasCompleted;
}
