using System;

/// <summary>
/// ��������� ���������
/// </summary>
public interface ITutorial
{
    /// <summary>
    /// ������� - �������� ���������� ���� ���������
    /// </summary>
    public event Action<ITutorial> onCompleteTutorial;

    /// <summary>
    /// ������� - ������ ���� ���������
    /// </summary>
    public event Action<ITutorial> onStartTutorial;

    /// <summary>
    /// ��������� ��� ���������
    /// </summary>
    public void StartTutorial();

    /// <summary>
    /// ���������� ���� ���������
    /// </summary>
    public void CompleteTutorial();
}
