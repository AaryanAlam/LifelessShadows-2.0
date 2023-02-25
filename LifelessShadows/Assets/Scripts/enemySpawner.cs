using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemySpawner : MonoBehaviour
{
     public GameObject enemyPrefab;
    public int initialNumberOfEnemiesToSpawn = 10;
    public float spawnRadius = 10f;
    public Terrain terrain;
    public float timeBetweenSpawns = 60f;

    private int numberOfEnemiesToSpawn;
    private float timeSinceLastSpawn;

    private void Start()
    {
        numberOfEnemiesToSpawn = initialNumberOfEnemiesToSpawn;
        timeSinceLastSpawn = 0f;
    }

    private void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= timeBetweenSpawns)
        {
            numberOfEnemiesToSpawn++;
            timeSinceLastSpawn = 0f;
        }

        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        for (int i = 0; i < numberOfEnemiesToSpawn; i++)
        {
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            randomPosition.y = terrain.SampleHeight(randomPosition);

            while (!IsPositionOnTerrain(randomPosition))
            {
                randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
                randomPosition.y = terrain.SampleHeight(randomPosition);
            }

            GameObject enemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            NavMeshAgent navMeshAgent = enemy.GetComponentInChildren<NavMeshAgent>();
            navMeshAgent.SetDestination(GetRandomPointOnTerrain());
        }
    }

    private bool IsPositionOnTerrain(Vector3 position)
    {
        Vector3 terrainPosition = terrain.transform.position;
        Vector3 terrainSize = terrain.terrainData.size;

        if (position.x < terrainPosition.x || position.x > terrainPosition.x + terrainSize.x ||
            position.z < terrainPosition.z || position.z > terrainPosition.z + terrainSize.z)
        {
            return false;
        }

        float terrainHeight = terrain.SampleHeight(position);
        if (position.y < terrainHeight)
        {
            return false;
        }

        return true;
    }

    private Vector3 GetRandomPointOnTerrain()
    {
        float randomX = Random.Range(0f, terrain.terrainData.size.x);
        float randomZ = Random.Range(0f, terrain.terrainData.size.z);
        float terrainHeight = terrain.SampleHeight(new Vector3(randomX, 0f, randomZ));
        return new Vector3(randomX, terrainHeight, randomZ);
    }
}

