using System.Collections.Generic;

using static TutorialController;

/// <summary>
/// Обработчик сохранения туториала
/// </summary>
public class TutorialSaver
{
    private ISaveLoad saveLoad;

    public  TutorialSaver(string keyPrefs)
    {
        saveLoad = new SaverJson(keyPrefs);
    }

    /// <summary>
    /// Сохранить данные туториалов
    /// </summary>
    /// <param name="settingDataTutorial"></param>
    public void Save(List<SettingDataTutorial> settingDataTutorial)
    {
        SaveDataTutorial saveDataTutorial = new SaveDataTutorial();

        saveDataTutorial.tutorialSaveDatas = new List<TutorialSaveData>();

        foreach (var settingData in settingDataTutorial)
        {
            TutorialSaveData saveData = new TutorialSaveData();

            saveData.NameTutorial = settingData.NameTutrial;
            saveData.StepsSaveDatas = new List<StepsSaveData>();

            foreach (var stepTutorial in settingData.StepsTutorial)
            {
                StepsSaveData stepsSaveData = new StepsSaveData();
                stepsSaveData.hasCompleted = stepTutorial.hasCompleted;
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

        foreach (var settingData in settingsDatas)
        {
            foreach (var tutorialSaveData in saveDataTutorial.tutorialSaveDatas)
            {
                if (tutorialSaveData.NameTutorial == settingData.NameTutrial)
                {
                    foreach (var stepTutorial in settingData.StepsTutorial)
                    {
                        foreach (var stepsSaveData in tutorialSaveData.StepsSaveDatas)
                        {
                            stepTutorial.hasCompleted = stepsSaveData.hasCompleted;
                        }
                    }
                }
            }
        }
    }
}
