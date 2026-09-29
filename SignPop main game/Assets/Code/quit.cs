using UnityEngine;


public class quit : MonoBehaviour
{
   public void DoExitGame()
    {
        Debug.Log("Game is exiting");
        Application.Quit();

    }
}
