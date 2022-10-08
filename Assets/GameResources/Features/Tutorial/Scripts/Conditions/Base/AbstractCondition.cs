using UnityEngine;

/// <summary>
/// ������� ����� ������������ �������
/// </summary>
public abstract class AbstractCondition : ScriptableObject
{
    /// <summary>
    /// �������� ��������� �� ����������� �������
    /// </summary>
    public abstract bool CheckCondition();  
}
