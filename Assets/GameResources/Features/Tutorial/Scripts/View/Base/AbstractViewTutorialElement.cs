using UnityEngine;

/// <summary>
/// ����������� ������������ �������� ���������
/// </summary>
public abstract class AbstractViewTutorialElement : ScriptableObject
{
    [SerializeField]
    protected GameObject prefabElement;

    [SerializeField]
    protected bool isActive = true;

    protected GameObject initElement = default;

    /// <summary>
    /// ���������������� ������� ������������
    /// </summary>
    /// <param name="content"></param>
    /// TODO: ����������� ������ ��� ������������
    public virtual void InitViewElement(Transform content)
    {
        if (initElement == null && isActive)
        {
            initElement = Instantiate(prefabElement, content);
        }
    }

    /// <summary>
    /// ���������� ������� ������������
    /// </summary>
    /// <param name="stepTutorial"></param>
    public abstract void ShowElement (StepTutorial stepTutorial);

    /// <summary>
    /// �������� ������� ������������
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
