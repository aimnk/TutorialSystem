using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Клик по кнопке для прохождения шага туториала
/// </summary>
[RequireComponent(typeof(Button))]
public class TutorialClickButtonAction : AbtractTutorialAction
{
    [SerializeField]
    private int neededCounClick = 1;

    private int countClick;

    private Button button;

    public override void StartAction() => button.onClick.AddListener(OnButtonClicked);

    private void Awake() => button = GetComponent<Button>();

    private void OnButtonClicked()
    {
        countClick++;

        if (countClick >= neededCounClick)
        {
            button.onClick.RemoveListener(OnButtonClicked);
            EndAction();
        }
    }    
}
