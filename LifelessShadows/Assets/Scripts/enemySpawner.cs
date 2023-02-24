using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRadius;

    void Start()
    {
        // Spawn a single enemy at a random position within the spawn radius
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }

    // Call this method to spawn additional enemies
    public void SpawnEnemies(int count)
    {
        for (int i = 0; i < count; i++)
        {
            SpawnEnemy();
        }
    }
}
