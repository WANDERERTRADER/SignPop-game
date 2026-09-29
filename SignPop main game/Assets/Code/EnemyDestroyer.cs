using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            int count = DestroyEnemies("Enemy01", true);
            Scoremanager.instance.Addpoint(count);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            int count = DestroyEnemies("Enemy02", true);
            Scoremanager.instance.Addpoint(count);
        }

        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            int count = DestroyEnemies("Enemy03", true);
            Scoremanager.instance.Addpoint(count);
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            if (ItemUIManager.instance.RemoveItem())
            {
                DestroyAllEnemies();
            }

        }
    }

    int DestroyEnemies(string tagName, bool dropItem)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(tagName);

        int count = enemies.Length;

        foreach (GameObject enemy in enemies)
        {
            // บอก Enemy ว่าจะให้ Drop Item หรือไม่
            EnemyDrop drop = enemy.GetComponent<EnemyDrop>();

            if (drop != null)
            {
                drop.canDrop = dropItem;
            }

            Destroy(enemy);
        }

        return count;
    }
    void DestroyAllEnemies()
    {
        DestroyEnemies("Enemy01", false);
        DestroyEnemies("Enemy02", false);
        DestroyEnemies("Enemy03", false);
    }
}