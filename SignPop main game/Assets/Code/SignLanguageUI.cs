using UnityEngine;
using UnityEngine.UI;

public class SignLanguageUI : MonoBehaviour
{
    public GameObject dimBackground;
    public GameObject signLanguagePanel;

    public GameObject[] pages;

    public Button leftArrow;
    public Button rightArrow;

    private int currentPage = 0;

    void Start()
    {
        dimBackground.SetActive(false);
        signLanguagePanel.SetActive(false);

        currentPage = 0;
        UpdatePage();
    }

    public void OpenSignLanguage()
    {
        dimBackground.SetActive(true);
        signLanguagePanel.SetActive(true);

        currentPage = 0;
        UpdatePage();
    }

    public void CloseSignLanguage()
    {
        dimBackground.SetActive(false);
        signLanguagePanel.SetActive(false);
    }

    public void NextPage()
    {
        if (currentPage < pages.Length - 1)
        {
            currentPage++;
            UpdatePage();
        }
    }

    public void PreviousPage()
    {
        if (currentPage > 0)
        {
            currentPage--;
            UpdatePage();
        }
    }

    void UpdatePage()
    {
        // เปิดเฉพาะหน้าปัจจุบัน
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(i == currentPage);
        }

        // หน้าแรก = ปิดลูกศรซ้าย
        leftArrow.interactable = currentPage > 0;

        // หน้าสุดท้าย = ปิดลูกศรขวา
        rightArrow.interactable = currentPage < pages.Length - 1;
    }
}