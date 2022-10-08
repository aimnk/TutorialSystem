using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���������� ����������, �������� �� ������������� ���������� � �� ������
/// </summary>
public class TutorialController : MonoBehaviour
{
    /// <summary>
    /// ������� - ������������� �����������
    /// </summary>
    public Action OnInit = delegate { };

    /// <summary>
    /// ������ ��������� ����������
    /// </summary>
    public IReadOnlyList<ITutorial> Tutorials => tutorialPool.Tutorials;

    private const int TIME_SLEEP = 1000;

    private const string PLAYER_PREFS_KEY = "TutorialData";

    [SerializeField]
    private List<SettingDataTutorial> settingsDatas;

    [SerializeField]
    private TutorialHandler tutorialHandler;

    private TutorialPool tutorialPool;

    private TutorialSaver tutorialSaver;

    private void Awake() => tutorialHandler.onCompleteTutorial += OnCompleteTutorial;

    private void Start() => Init();

    private void LoadData()
    {
        tutorialSaver = new TutorialSaver(PLAYER_PREFS_KEY);
        tutorialSaver.Load(settingsDatas);
    }

    private void Init()
    {
        List<ITutorial> tutorials = new List<ITutorial>();

        LoadData();

        foreach (var item in settingsDatas)
        {
            tutorials.Add(new Tutorial(item.StepsTutorial, item.Condition));
        }

        tutorialPool = new TutorialPool(tutorials);

        OnInit.Invoke();

        _ = WaitUntilConditions(TryStartTutorial);
      
    }

    private void OnCompleteTutorial(ITutorial tutorial)
    {
        tutorialSaver.Save(settingsDatas);
        _ = WaitUntilConditions(TryStartTutorial, TIME_SLEEP);
    }

    private bool TryStartTutorial()
    {
        if (tutorialPool.GetTutorial() is ITutorial tutorial and not null)
        {
            tutorial.StartTutorial();
            return true;
        }

        return false;
    }

    /// <summary>
    /// TODO: �������� ����� ���������� �� ������� ����������� �������
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="sleep"></param>
    /// <returns></returns>
    private async UniTask WaitUntilConditions(Func<bool> predicate, int sleep = TIME_SLEEP)
    {
        await UniTask.DelayFrame(1);

        while (!predicate() && tutorialPool.Tutorials.Count > 0)
        {
            await UniTask.Delay(sleep);
        }
    }

    private void OnDestroy() => tutorialHandler.onCompleteTutorial -= OnCompleteTutorial;

    /// <summary>
    /// ���� �������� ��������� � ����������
    /// </summary>
    [Serializable]
    public class SettingDataTutorial
    {
        public string NameTutrial;

        public AbstractCondition Condition;

        public List<StepTutorial> StepsTutorial;
    }
}
