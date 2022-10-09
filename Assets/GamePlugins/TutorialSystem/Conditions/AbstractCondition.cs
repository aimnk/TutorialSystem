using UnityEngine;

namespace GamePlugins.TutorialSystem.Conditions
{
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
}
