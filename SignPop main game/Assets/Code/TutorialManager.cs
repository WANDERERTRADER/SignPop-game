using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    [System.Serializable]
    public class TutorialStep
    {
        [TextArea(2, 5)]
        public string text;

        public Sprite characterImage;

        [Header("UI Position")]
        public Vector2 characterPosition;
        public Vector2 dialoguePosition;
    }

    [Header("Tutorial UI")]
    public GameObject tutorialPanel;
    public RectTransform characterImage;
    public RectTransform dialogueBox;
    public TMP_Text dialogueText;

    [Header("Tutorial Steps")]
    public TutorialStep[] steps;

    private int currentStep = 0;

    private void Start()
    {
        currentStep = 0;
        ShowStep();
    }

    public void NextStep()
    {
        currentStep++;

        if (currentStep >= steps.Length)
        {
            EndTutorial();
            return;
        }

        ShowStep();
    }

    private void ShowStep()
    {
        TutorialStep step = steps[currentStep];

        // เปลี่ยนข้อความ
        dialogueText.text = step.text;

        // เปลี่ยนรูปตัวละคร
        if (step.characterImage != null)
        {
            characterImage.GetComponent<Image>().sprite = step.characterImage;
        }

        // เปลี่ยนตำแหน่ง
        characterImage.anchoredPosition = step.characterPosition;
        dialogueBox.anchoredPosition = step.dialoguePosition;
    }

    private void EndTutorial()
    {
        tutorialPanel.SetActive(false);
    }
}