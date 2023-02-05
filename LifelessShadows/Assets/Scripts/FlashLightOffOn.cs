using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightOffOn : MonoBehaviour
{
    public Light spotLight;
    public Light pointLight;
    public AudioSource source;
    public AudioClip ding;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            source.PlayOneShot(ding);
            spotLight.enabled = !spotLight.enabled;
            pointLight.enabled = !pointLight.enabled;
        }
    }
}
