using GamePlugins.TutorialSystem.View.Data;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace GameResources.ExampleTutorialSystem.View
{
    /// <summary>
    /// Отображение описания для туториала
    /// </summary>
    public class ViewDescription : MonoBehaviour
    {
        [SerializeField]
        private Text descriptionInfo;

        [SerializeField]
        private Text noteInfo;

        [SerializeField]
        private GameObject noteContent;

        /// <summary>
        /// Показать описание
        /// </summary>
        /// <param name="viewTutorialData"></param>
        public void ShowDescriptions(ViewTutorialData viewTutorialData)
        {
            descriptionInfo.text = viewTutorialData.InfoTutorialDatas.DestriptionInfo;
            noteInfo.text = viewTutorialData.InfoTutorialDatas.NoteInfo;
            noteContent.SetActive(!string.IsNullOrWhiteSpace(viewTutorialData.InfoTutorialDatas.NoteInfo));
        }
    }
}
