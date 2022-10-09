using System;
using System.Collections.Generic;

namespace GameResources.ExampleTutorialSystem.Saving
{
    [Serializable]
    public class SaveDataTutorial
    {
        public List<TutorialSaveData> tutorialSaveDatas;
    }

    [Serializable]
    public class StepsSaveData
    {
        public bool hasCompleted;
    }

    [Serializable]
    public class TutorialSaveData
    {
        public string NameTutorial;

        public List<StepsSaveData> StepsSaveDatas;
    }
}