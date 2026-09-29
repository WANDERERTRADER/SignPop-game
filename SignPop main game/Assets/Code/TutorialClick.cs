using UnityEngine;

public class TutorialClick : MonoBehaviour
{
    public TutorialManager tutorialManager;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tutorialManager.NextStep();
        }
    }
}