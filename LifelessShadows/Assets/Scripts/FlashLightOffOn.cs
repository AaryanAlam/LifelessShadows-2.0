using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightOffOn : MonoBehaviour
{
    public Light spotLight;
    public Light pointLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            spotLight.enabled = !spotLight.enabled;
            pointLight.enabled = !pointLight.enabled;
        }
    }
}
