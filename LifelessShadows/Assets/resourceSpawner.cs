using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class resourceSpawner : MonoBehaviour
{
    public GameObject object1;
    private Vector3 location;
    public Terrain terrain;

    public float spawnAmount;
    public float spreadAmount;

    public float x;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test 1");
        for (int i = 0; i < spawnAmount; i++)
        {
            Debug.Log("Test 2");
            Debug.Log("Test 3");


            x = Random.Range(0, spreadAmount);
            z = Random.Range(0, spreadAmount);
            Debug.Log("Test 4");


            
            Debug.Log("Test 5");


            location = new Vector3(x, 0, z);

            float terrainHeight = terrain.SampleHeight(location);

            location = new Vector3(x, terrainHeight + 1, z);

            Instantiate(object1, location, Quaternion.identity);
            Debug.Log("Test 6");

            Debug.Log("Test 7");


        
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void spawnTreeChunk()
    {
        

    }
}
