using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
public class Scoremanager : MonoBehaviour
{
    public static Scoremanager instance;    
    public Text scoretext;

    int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoretext.text = score.ToString("D5");
    }

    // Update is called once per frame
    public void Addpoint(int enemyCount)
    {
        score += enemyCount * 10;
        scoretext.text = score.ToString("D5");
    }
}
