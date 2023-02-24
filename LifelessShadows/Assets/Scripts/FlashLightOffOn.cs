using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightOffOn : MonoBehaviour
{
    public Light spotLight;
    public Light pointLight;
    public AudioSource source;
    public AudioClip ding;

    public bool ison = false;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("LightBuzz");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            FindObjectOfType<AudioManager>().Play("LightSwitch");
            spotLight.enabled = !spotLight.enabled;
            if (spotLight.enabled == true){
                ison = true;
            }
            else
            {
                ison = false;
            }
            pointLight.enabled = !pointLight.enabled;
        }
    }
}
