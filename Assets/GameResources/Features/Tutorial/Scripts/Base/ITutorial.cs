using System;

/// <summary>
/// Интерфейс туториала
/// </summary>
public interface ITutorial
{
    /// <summary>
    /// Событие - успешное завершение шага туториала
    /// </summary>
    public event Action<ITutorial> onCompleteTutorial;

    /// <summary>
    /// Событие - запуск шага туториала
    /// </summary>
    public event Action<ITutorial> onStartTutorial;

    /// <summary>
    /// Запустить шаг туториала
    /// </summary>
    public void StartTutorial();

    /// <summary>
    /// Завершение шага туториала
    /// </summary>
    public void CompleteTutorial();
}
