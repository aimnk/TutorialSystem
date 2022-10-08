using UnityEngine;

/// <summary>
/// Базовый класс необходимого условия
/// </summary>
public abstract class AbstractCondition : ScriptableObject
{
    /// <summary>
    /// Проверка выполнено ли необходимое условие
    /// </summary>
    public abstract bool CheckCondition();  
}
