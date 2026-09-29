using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelButtonHover : MonoBehaviour,
    IPointerEnterHandler,
    IPointerExitHandler
{
    [Header("Scale")]
    public float hoverScale = 1.5f;

    [Header("Animation")]
    public float speed = 10f;

    [Header("Layout")]
    public float hoverHeight = 150f;

    private Vector3 originalScale;
    private Vector3 targetScale;

    private LayoutElement layoutElement;
    private float originalHeight;

    private bool isHover = false;

    private void Start()
    {
        originalScale = transform.localScale;
        targetScale = originalScale;

        layoutElement = GetComponentInParent<LayoutElement>();

        if (layoutElement != null)
        {
            originalHeight = layoutElement.preferredHeight;
        }
    }

    private void Update()
    {
        // Scale
        transform.localScale = Vector3.Lerp(
            transform.localScale,
            targetScale,
            Time.deltaTime * speed
        );

        // Layout Height
        if (layoutElement != null)
        {
            float targetHeight = isHover
                ? hoverHeight
                : originalHeight;

            layoutElement.preferredHeight = Mathf.Lerp(
                layoutElement.preferredHeight,
                targetHeight,
                Time.deltaTime * speed
            );
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHover = true;

        targetScale = originalScale * hoverScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHover = false;

        targetScale = originalScale;
    }
}