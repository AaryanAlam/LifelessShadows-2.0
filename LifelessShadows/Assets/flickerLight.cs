using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickerLight : MonoBehaviour
{
    public float rndNum;
    public float rndNumTime;
    public float time = 1;
    public Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        rndNum = Random.Range(1, 5);
        rndNumTime = Random.Range(1, 2);
        time -= Time.deltaTime;
        
        if (time <= 0 || time >= 1)
        {
            rndNumTime = Random.Range(1, 2);
            light.intensity = rndNum;
        }

    }
}
