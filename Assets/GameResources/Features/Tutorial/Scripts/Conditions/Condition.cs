using UnityEngine;

/// <summary>
/// ������� ��������� ������
/// </summary>
[CreateAssetMenu(fileName = nameof(Condition), menuName = "Tutorial/Condition/Create/" + nameof(Condition))]
public class Condition : AbstractCondition
{
    protected bool stateCondition;

    public override bool CheckCondition() => true;
}
