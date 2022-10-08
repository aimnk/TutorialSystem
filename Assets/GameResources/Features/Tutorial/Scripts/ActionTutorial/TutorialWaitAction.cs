using Cysharp.Threading.Tasks;
using UnityEngine;

/// <summary>
/// Ожидание определенного времени для завершения шага туториала
/// </summary>
public class TutorialWaitAction : AbtractTutorialAction
{
    [SerializeField]
    private int timeDelay = 5;

    public async override void StartAction()
    {
        await UniTask.Delay(timeDelay * 1000);
        EndAction();
    }

}
