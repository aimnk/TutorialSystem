using System.Collections.Generic;
using GamePlugins.SaveSystem;
using static GamePlugins.TutorialSystem.Base.TutorialController;

namespace GameResources.ExampleTutorialSystem.Saving
{
    /// <summary>
    /// Обработчик сохранения туториала
    /// </summary>
    public class TutorialSaver
    {
        private readonly ISaveLoad saveLoad;

        public TutorialSaver(string keyPrefs)
        {
            saveLoad = new SaverJson(keyPrefs);
        }

        /// <summary>
        /// Сохранить данные туториалов
        /// </summary>
        /// <param name="settingDataTutorial"></param>
        public void Save(List<SettingDataTutorial> settingDataTutorial)
        {
            var saveDataTutorial = new SaveDataTutorial();

            saveDataTutorial.tutorialSaveDatas = new List<TutorialSaveData>();

            foreach (var settingData in settingDataTutorial)
            {
                var saveData = new TutorialSaveData();

                saveData.NameTutorial = settingData.NameTutrial;
                saveData.StepsSaveDatas = new List<StepsSaveData>();

                foreach (var stepTutorial in settingData.StepsTutorial)
                {
                    var stepsSaveData = new StepsSaveData();
                    stepsSaveData.hasCompleted = stepTutorial.HasCompleted;
                    saveData.StepsSaveDatas.Add(stepsSaveData);
                }

                saveDataTutorial.tutorialSaveDatas.Add(saveData);
            }

            saveLoad.Save(saveDataTutorial);
        }

        /// <summary>
        /// Загрузить данные туториалов
        /// </summary>
        public void Load(List<SettingDataTutorial> settingsDatas)
        {
            var saveDataTutorial = saveLoad.Load<SaveDataTutorial>();

            if (saveDataTutorial == null)
            {
                return;
            }

            foreach (var settingData in settingsDatas)
            {
                foreach (var tutorialSaveData in saveDataTutorial.tutorialSaveDatas)
                {
                    if (tutorialSaveData.NameTutorial != settingData.NameTutrial)
                    {
                        continue;
                    }

                    foreach (var stepTutorial in settingData.StepsTutorial)
                    {
                        foreach (var stepsSaveData in tutorialSaveData.StepsSaveDatas)
                        {
                            stepTutorial.HasCompleted = stepsSaveData.hasCompleted;
                        }
                    }
                }
            }
        }
    }
}
