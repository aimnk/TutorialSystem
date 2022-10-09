using GamePlugins.TutorialSystem.Conditions;
using UnityEngine;

namespace GameResources.ExampleTutorialSystem.Conditions
{
    /// <summary>
    /// Условие всегда выполнено
    /// </summary>
    [CreateAssetMenu(fileName = nameof(Condition), menuName = "Tutorial/Condition/Create/" + nameof(Condition))]
    public class Condition : AbstractCondition
    {
        public override bool CheckCondition() => true;
    }
}
