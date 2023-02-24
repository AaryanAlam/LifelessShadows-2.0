using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int spawnRadius;
    private int randomNum;
    public int spawnCount;

    void Start()
    {
        // Spawn a single enemy at a random position within the spawn radius
        SpawnEnemies(spawnCount);
    }

    void SpawnEnemy()
    {
        System.Random rnd = new System.Random();
        randomNum = rnd.Next(0, spawnRadius);

        Vector3 spawnPosition = new Vector3(randomNum, 1, randomNum);
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
