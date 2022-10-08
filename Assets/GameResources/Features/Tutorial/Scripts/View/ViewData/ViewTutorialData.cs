using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Дата отображения туториала
/// </summary>
[CreateAssetMenu(fileName = nameof(ViewTutorialData), menuName = "Tutorial/View/Create/" + nameof(ViewTutorialData))]
public class ViewTutorialData : ScriptableObject
{
    /// <summary>
    /// Дата описания туториала
    /// </summary>
    public InfoTutorialData InfoTutorialDatas => infoTutorialData;

    /// <summary>
    /// Элменты визуализации туториала
    /// </summary>
    public IReadOnlyList<AbstractViewTutorialElement> ViewTutorialElements => abstractViewTutorialElements;

    [SerializeField]
    private InfoTutorialData infoTutorialData;

    [SerializeField]
    private List<AbstractViewTutorialElement> abstractViewTutorialElements;

    /// <summary>
    /// Дата описания туториала
    /// </summary>
    [Serializable]
    public class InfoTutorialData
    {
        public string DestriptionInfo;

        public string NoteInfo;
    }
}
