using System;
using UnityEngine;

namespace GamePlugins.TutorialSystem.TutorialActions
{
    /// <summary>
    /// Абстрактное действие для прохождения шага туториала
    /// </summary>
    public abstract class AbstractTutorialAction : MonoBehaviour
    {
        /// <summary>
        /// Событие - выполнение необходимого действия
        /// </summary>
        public event Action onCompleteAction = delegate { };

        /// <summary>
        /// Необходимое действие для завершения туториала
        /// </summary>
        public abstract void StartAction();

        /// <summary>
        /// Завершение необходимого действия
        /// </summary>
        protected virtual void EndAction() => onCompleteAction.Invoke();
    }
}