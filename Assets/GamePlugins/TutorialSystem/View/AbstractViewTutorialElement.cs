using GamePlugins.TutorialSystem.Base;
using UnityEngine;

namespace GamePlugins.TutorialSystem.View
{
    /// <summary>
    /// Абстрактное представление визуализации элемента туториала
    /// </summary>
    public abstract class AbstractViewTutorialElement : ScriptableObject
    {
        [SerializeField]
        protected GameObject prefabElement;

        [SerializeField]
        protected bool isActive = true;

        protected GameObject InitElement = default;

        /// <summary>
        /// Инциализировать элемент визуализации
        /// </summary>
        /// <param name="content"></param>
        /// TODO: сделать пул обьектов
        public virtual void InitViewElement(Transform content)
        {
            if (InitElement == null && isActive)
            {
                InitElement = Instantiate(prefabElement, content);
            }
        }

        /// <summary>
        /// Отобразить элемент визуализации
        /// </summary>
        /// <param name="stepTutorial"></param>
        public abstract void ShowElement (StepTutorial stepTutorial);

        /// <summary>
        /// Спрятать/показать визуализации
        /// </summary>
        /// <param name="state"></param>
        public void HideViewElementView(bool state)
        {
            if (InitElement != null)
            {
                InitElement.SetActive(state);
            }
        }
    }
}
