using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;

    public Transform LeftSpawn;
    public Transform RightSpawn;

    public float spawnTime = 1f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnTime);
    }

    void SpawnEnemy()
    {
        int randomEnemy = Random.Range(0, enemies.Length);

        float x = Random.Range(LeftSpawn.position.x,
                               RightSpawn.position.x);

        Vector3 spawnPos = new Vector3(
            x,
            LeftSpawn.position.y,
            0f);

        Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity);
    }
}