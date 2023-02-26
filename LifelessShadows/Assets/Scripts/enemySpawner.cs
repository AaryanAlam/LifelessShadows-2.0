using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemySpawner : MonoBehaviour
{
     public GameObject enemyPrefab;
    public int numberOfEnemiesToSpawn = 10;
    public float spawnRadius = 10f;
    public Terrain terrain;

    private void Start()
    {
        for (int i = 0; i < numberOfEnemiesToSpawn; i++)
        {
            // Calculate a random position within the spawn radius.
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            // Set the Y coordinate of the random position to the height of the terrain at that location.
            randomPosition.y = terrain.SampleHeight(randomPosition);

            // If the random position is outside of the terrain bounds, try again with a new position.
            while (!IsPositionOnTerrain(randomPosition))
            {
                randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
                randomPosition.y = terrain.SampleHeight(randomPosition);
            }

            // Instantiate the enemy prefab at the random position.
            GameObject enemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            // Set the destination of the navmesh agent to a random point on the terrain.
            NavMeshAgent navMeshAgent = enemy.GetComponentInChildren<NavMeshAgent>();
            navMeshAgent.SetDestination(GetRandomPointOnTerrain());
        }
    }

    private bool IsPositionOnTerrain(Vector3 position)
    {
        // Get the position of the terrain object in world space.
        Vector3 terrainPosition = terrain.transform.position;
        // Get the size of the terrain in world space.
        Vector3 terrainSize = terrain.terrainData.size;

        // Check if the position is inside the bounds of the terrain.
        if (position.x < terrainPosition.x || position.x > terrainPosition.x + terrainSize.x ||
            position.z < terrainPosition.z || position.z > terrainPosition.z + terrainSize.z)
        {
            return false;
        }

        // Check if the position is above the terrain surface.
        float terrainHeight = terrain.SampleHeight(position);
        if (position.y < terrainHeight)
        {
            return false;
        }

        return true;
    }

    private Vector3 GetRandomPointOnTerrain()
    {
        // Generate a random point on the terrain by selecting random X and Z coordinates within the terrain bounds.
        float randomX = Random.Range(0f, terrain.terrainData.size.x);
        float randomZ = Random.Range(0f, terrain.terrainData.size.z);
        // Get the height of the terrain at the selected X and Z coordinates.
        float terrainHeight = terrain.SampleHeight(new Vector3(randomX, 0f, randomZ));
        // Return the random point on the terrain.
        return new Vector3(randomX, terrainHeight, randomZ);
    }
}

