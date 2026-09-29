using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ImageHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image image;
    public Sprite normalImage;
    public Sprite hoverImage;

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.sprite = hoverImage;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.sprite = normalImage;
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
