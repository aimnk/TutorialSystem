using System;

/// <summary>
/// Интерфейс туториала
/// </summary>
public interface ITutorial
{
    /// <summary>
    /// Событие - туториал завершен
    /// </summary>
    public event Action<ITutorial> onCompleteTutorial;

    /// <summary>
    /// Событие - начало туториала
    /// </summary>
    public event Action<ITutorial> onStartTutorial;

    /// <summary>
    /// Запустить туториал
    /// </summary>
    public void StartTutorial();

    /// <summary>
    /// Завершить туториал
    /// </summary>
    public void CompleteTutorial();
}
