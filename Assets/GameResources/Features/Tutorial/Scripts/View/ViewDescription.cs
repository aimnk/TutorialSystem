using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Отображение описания туториала
/// </summary>
public class ViewDescription : MonoBehaviour
{
    [SerializeField]
    private Text destriptionsInfo;

    [SerializeField]
    private Text noteInfo;

    [SerializeField]
    private GameObject NoteContent;

    /// <summary>
    /// Показать описание туториала
    /// </summary>
    /// <param name="viewTutorialData"></param>
    public void ShowDescriptions(ViewTutorialData viewTutorialData)
    {
        destriptionsInfo.text = viewTutorialData.InfoTutorialDatas.DestriptionInfo;
        noteInfo.text = viewTutorialData.InfoTutorialDatas.NoteInfo;
        NoteContent.SetActive(!string.IsNullOrWhiteSpace(viewTutorialData.InfoTutorialDatas.NoteInfo));
    }
}
