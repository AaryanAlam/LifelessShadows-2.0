using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class resourceSpawner : MonoBehaviour
{
    public GameObject plank;
    public GameObject plastic;
    public GameObject SOG;
    public GameObject copper;
    public GameObject scrap;
    public GameObject flint;
    public GameObject iron;
    public GameObject stone;
    private Vector3 location;
    public Terrain terrain;

    public float plankAmount;
    public float ironAmount;
    public float stoneAmount;
    public float flintAmount;
    public float scrapAmount;
    public float copperAmount;
    public float SOGAmount;
    public float plasticAmount;
    public float spreadAmount;

    public GameObject SOGZone;

    public float x;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < plankAmount; i++)
        {

            x = Random.Range(0, spreadAmount);
            z = Random.Range(0, spreadAmount);

            Quaternion rotation = Quaternion.Euler(0, x, -90);

            location = new Vector3(x, 0, z);

            float terrainHeight = terrain.SampleHeight(location);

            location = new Vector3(x, terrainHeight + 0.5f, z);

            Instantiate(plank, location, rotation);
        }

        for (int i = 0; i < ironAmount; i++)
        {

            x = Random.Range(0, spreadAmount);
            z = Random.Range(0, spreadAmount);

            Quaternion rotation = Quaternion.Euler(0, x, -90);

            location = new Vector3(x, 0, z);

            float terrainHeight = terrain.SampleHeight(location);

            location = new Vector3(x, terrainHeight + 0.5f, z);

            Instantiate(iron, location, rotation);

            
        }

        for (int i = 0; i < stoneAmount; i++)
        {

            x = Random.Range(0, spreadAmount);
            z = Random.Range(0, spreadAmount);

            Quaternion rotation = Quaternion.Euler(0, x, -90);

            location = new Vector3(x, 0, z);

            float terrainHeight = terrain.SampleHeight(location);

            location = new Vector3(x, terrainHeight + 0.5f, z);

            Instantiate(stone, location, rotation);
        }

        for (int i = 0; i < flintAmount; i++)
        {

            x = Random.Range(0, spreadAmount);
            z = Random.Range(0, spreadAmount);

            Quaternion rotation = Quaternion.Euler(0, x, -90);

            location = new Vector3(x, 0, z);

            float terrainHeight = terrain.SampleHeight(location);

            location = new Vector3(x, terrainHeight + 0.5f, z);

            Instantiate(flint, location, rotation);
        }

        for (int i = 0; i < scrapAmount; i++)
        {

            x = Random.Range(0, spreadAmount);
            z = Random.Range(0, spreadAmount);

            Quaternion rotation = Quaternion.Euler(0, x, -90);

            location = new Vector3(x, 0, z);

            float terrainHeight = terrain.SampleHeight(location);

            location = new Vector3(x, terrainHeight + 0.5f, z);

            Instantiate(scrap, location, rotation);
        }

        for (int i = 0; i < copperAmount; i++)
        {

            x = Random.Range(0, spreadAmount);
            z = Random.Range(0, spreadAmount);

            Quaternion rotation = Quaternion.Euler(0, x, -90);

            location = new Vector3(x, 0, z);

            float terrainHeight = terrain.SampleHeight(location);

            location = new Vector3(x, terrainHeight + 0.5f, z);

            Instantiate(copper, location, rotation);
        }

        for (int i = 0; i < SOGAmount; i++)
        {

            x = Random.Range(0, 2);
            z = Random.Range(0, 2);

            Quaternion rotation = Quaternion.Euler(0, x, -90);

            location = new Vector3(x, 0, z);

            float terrainHeight = terrain.SampleHeight(location);

            location = new Vector3(x, terrainHeight + 0.5f, z);

            GameObject SOG2 = Instantiate(SOG, location, rotation, SOGZone.transform);
            SOG2.transform.localPosition = new Vector3(x, transform.position.y - 30, z);
        }

        for (int i = 0; i < plasticAmount; i++)
        {

            x = Random.Range(0, spreadAmount);
            z = Random.Range(0, spreadAmount);

            Quaternion rotation = Quaternion.Euler(0, x, -90);

            location = new Vector3(x, 0, z);

            float terrainHeight = terrain.SampleHeight(location);

            location = new Vector3(x, terrainHeight + 0.5f, z);

            Instantiate(plastic, location, rotation);
        }
    }
}
