using System.Collections.Generic;

/// <summary>
/// ��� ��������� ����������
/// </summary>
public class TutorialPool
{
    /// <summary>
    /// ������ ��������� ����������
    /// </summary>
    public IReadOnlyList<ITutorial> Tutorials => tutorials;

    private List<ITutorial> tutorials = new List<ITutorial>();

    public TutorialPool(List<ITutorial> tutorial)
    {
       this.tutorials = tutorial;
       InitPool();
    }

    /// <summary>
    /// ����� �������� ���������� ����������� �������
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
    /// ���������� �������� �� ���� ��� ����������
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
