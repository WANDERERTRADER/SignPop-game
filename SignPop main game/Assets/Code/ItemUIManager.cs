using UnityEngine;
using UnityEngine.UI;

public class ItemUIManager : MonoBehaviour
{
    public static ItemUIManager instance;

    [Header("Item Slots")]
    public Image[] itemSlots;

    [Header("Alpha")]
    public float emptyAlpha = 0.5f;
    public float fullAlpha = 1f;

    private int itemCount = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public bool AddItem()
    {
        // มีครบ 3 ชิ้นแล้ว
        if (itemCount >= 3)
        {
            return false;
        }

        itemCount++;

        UpdateUI();

        return true;
    }
    public bool RemoveItem()
    {
        // ไม่มี Item
        if (itemCount <= 0)
        {
            return false;
        }

        // ลด Item
        itemCount--;

        UpdateUI();

        return true;
    }
    private void UpdateUI()
    {
        for (int i = 0; i < itemSlots.Length; i++)
        {
            Color color = itemSlots[i].color;

            if (i < itemCount)
            {
                // มี Item
                color.a = fullAlpha;
            }
            else
            {
                // ยังไม่มี Item
                color.a = emptyAlpha;
            }

            itemSlots[i].color = color;
        }
    }
}