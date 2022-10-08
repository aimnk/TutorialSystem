using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���� ����������� ���� ���������
/// </summary>
[CreateAssetMenu(fileName = nameof(ViewTutorialData), menuName = "Tutorial/View/Create/" + nameof(ViewTutorialData))]
public class ViewTutorialData : ScriptableObject
{
    /// <summary>
    /// ���� �������� ���� ���������
    /// </summary>
    public InfoTutorialData InfoTutorialDatas => infoTutorialData;

    /// <summary>
    /// ������ ��������� ������������ � ���������
    /// </summary>
    public IReadOnlyList<AbstractViewTutorialElement> ViewTutorialElements => abstractViewTutorialElements;

    [SerializeField]
    private InfoTutorialData infoTutorialData;

    [SerializeField]
    private List<AbstractViewTutorialElement> abstractViewTutorialElements;

    /// <summary>
    /// ���� �������� ��������� ��� ���� ���������
    /// </summary>
    [Serializable]
    public class InfoTutorialData
    {
        public string DestriptionInfo;

        public string NoteInfo;
    }
}
