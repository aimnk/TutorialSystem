using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Дата визуалиации шага туториала
/// </summary>
[CreateAssetMenu(fileName = nameof(ViewTutorialData), menuName = "Tutorial/View/Create/" + nameof(ViewTutorialData))]
public class ViewTutorialData : ScriptableObject
{
    /// <summary>
    /// Дата описаний шага туториала
    /// </summary>
    public InfoTutorialData InfoTutorialDatas => infoTutorialData;

    /// <summary>
    /// Вьюшка элементов визуализации в туториале
    /// </summary>
    public IReadOnlyList<AbstractViewTutorialElement> ViewTutorialElements => abstractViewTutorialElements;

    [SerializeField]
    private InfoTutorialData infoTutorialData;

    [SerializeField]
    private List<AbstractViewTutorialElement> abstractViewTutorialElements;

    /// <summary>
    /// Дата описаний туториала для шага туториала
    /// </summary>
    [Serializable]
    public class InfoTutorialData
    {
        public string DestriptionInfo;

        public string NoteInfo;
    }
}
