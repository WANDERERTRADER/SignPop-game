
using Unity.VisualScripting;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    [Header("Drop Settings")]
    public GameObject[] dropItems;

    [Range(0f, 100f)]
    public float dropChance = 50f;

    public bool canDrop = true;

    private void OnDestroy()
    {
        if (!canDrop)
            return;

        DropItem();
    }

    public void DropItem()
    {
        // เช็กโอกาสดรอป
        if (Random.Range(0f, 100f) > dropChance)
        {
            return;
        }

        // ไม่มี Item ให้ดรอป
        if (dropItems.Length == 0)
        {
            return;
        }

        if (ItemUIManager.instance != null)
        {
            ItemUIManager.instance.AddItem();
        }
        // สุ่ม Item
        int randomIndex = Random.Range(0, dropItems.Length);

        // สร้าง Item ตรงตำแหน่ง Enemy
        Instantiate(
            dropItems[randomIndex],
            transform.position,
            Quaternion.identity
        );
    }

}

