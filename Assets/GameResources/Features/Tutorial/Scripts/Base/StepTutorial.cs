using System;
using UnityEngine;

/// <summary>
/// ���� ��� ���� ���������
/// </summary>
[Serializable]
public class StepTutorial
{
    /// <summary>
    /// ���� ������������ ���������
    /// </summary>
    public ViewTutorialData viewTutorialData;

    /// <summary>
    /// �������� ���������� ��� ���������� ���� ���������
    /// </summary>
    public AbtractTutorialAction TutorialAction;

    /// <summary>
    /// �������� �� ��� ���������?
    /// </summary>
    public bool hasCompleted;
}
