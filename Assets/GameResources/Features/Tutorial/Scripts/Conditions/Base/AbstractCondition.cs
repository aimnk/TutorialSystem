using UnityEngine;

/// <summary>
/// Абстрактное условие
/// </summary>
public abstract class AbstractCondition : ScriptableObject
{
    /// <summary>
    /// Проверка - выполнено ли условие
    /// </summary>
    public abstract bool CheckCondition();  
}
