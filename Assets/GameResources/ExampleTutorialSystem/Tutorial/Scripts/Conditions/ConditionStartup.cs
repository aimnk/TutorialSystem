using GamePlugins.TutorialSystem.Conditions;
using UnityEngine;

namespace GameResources.ExampleTutorialSystem.Conditions
{
    /// <summary>
    /// Условие - пользователь провел определенное время после запуска
    /// </summary>
    [CreateAssetMenu(fileName = nameof(ConditionStartup), menuName = "Tutorial/Condition/Create/" + nameof(ConditionStartup))]
    public class ConditionStartup : AbstractCondition
    {
        [SerializeField]
        private int timeDelay = 15;

        public override bool CheckCondition() => Time.realtimeSinceStartup > timeDelay;
    }
}
