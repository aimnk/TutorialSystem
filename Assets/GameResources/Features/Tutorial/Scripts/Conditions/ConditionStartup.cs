using UnityEngine;

/// <summary>
/// Условие - пользователь провел опредленное время с начала запуска
/// </summary>
[CreateAssetMenu(fileName = nameof(ConditionStartup), menuName = "Tutorial/Condition/Create/" + nameof(ConditionStartup))]
public class ConditionStartup : AbstractCondition
{
    [SerializeField]
    private int timeDelay = 15;

    public override bool CheckCondition() => Time.realtimeSinceStartup > timeDelay;
}
