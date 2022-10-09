using UnityEngine;

namespace GamePlugins.SaveSystem
{
    /// <summary>
    /// Сохранение json данных в playerPrefs
    /// </summary>
    public class SaverJson : ISaveLoad
    {
        private readonly string playerPrefsKey;

        public SaverJson(string playerPrefsKey)
        {
            this.playerPrefsKey = playerPrefsKey;
        }

        public T Load<T>()
        {
            var data = PlayerPrefs.GetString(playerPrefsKey, string.Empty);
            return JsonUtility.FromJson<T>(data);
        }

        public void Save<T>(T data)
        {
            var saveData = JsonUtility.ToJson(data);
            PlayerPrefs.SetString(playerPrefsKey, saveData);
            PlayerPrefs.Save();
        }
    }
}
