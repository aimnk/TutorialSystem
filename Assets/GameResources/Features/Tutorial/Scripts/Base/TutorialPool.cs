using System.Collections.Generic;

/// <summary>
/// Пул туториалов
/// </summary>
public class TutorialPool
{
    /// <summary>
    /// Список доступных туториалов в пуле
    /// </summary>
    public IReadOnlyList<ITutorial> Tutorials => tutorials;

    private List<ITutorial> tutorials = new List<ITutorial>();

    public TutorialPool(List<ITutorial> tutorial)
    {
       this.tutorials = tutorial;
       InitPool();
    }

    /// <summary>
    /// Получить доступный туториалов отвечающий условию
    /// </summary>
    public ITutorial GetTutorial()
    {
        foreach (var tutorial in tutorials)
        {
            if ((tutorial as Tutorial).Condition.CheckCondition())
            {
                return tutorial;
            }
        }

        return null;
    }

    /// <summary>
    /// Освободить туториал из пула
    /// </summary>
    private void ReleaseTutorial(ITutorial task) => tutorials.Remove(task);

    private void InitPool()
    {
        foreach (var tutorial in tutorials)
        {
            tutorial.onCompleteTutorial += ReleaseTutorial;
        }
    }

    ~TutorialPool()
    {
        foreach (var tutorial in tutorials)
        {
            tutorial.onCompleteTutorial -= ReleaseTutorial;
        }
    }
}
