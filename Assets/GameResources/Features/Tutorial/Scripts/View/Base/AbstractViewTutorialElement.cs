using UnityEngine;

/// <summary>
/// Абстрактная визуализация элемента туториала
/// </summary>
public abstract class AbstractViewTutorialElement : ScriptableObject
{
    [SerializeField]
    protected GameObject prefabElement;

    [SerializeField]
    protected bool isActive = true;

    protected GameObject initElement = default;

    /// <summary>
    /// Инициализировать элемент визулазиации
    /// </summary>
    /// <param name="content"></param>
    /// TODO: освобождать обьект при ненадобности
    public virtual void InitViewElement(Transform content)
    {
        if (initElement == null && isActive)
        {
            initElement = Instantiate(prefabElement, content);
        }
    }

    /// <summary>
    /// Отобразить элемент визулазиации
    /// </summary>
    /// <param name="stepTutorial"></param>
    public abstract void ShowElement (StepTutorial stepTutorial);

    /// <summary>
    /// Спрятать элемент визулазиации
    /// </summary>
    /// <param name="state"></param>
    public void HideViewElementView(bool state)
    {
        if (initElement != null)
        {
            initElement.SetActive(state);
        }
    }
}
