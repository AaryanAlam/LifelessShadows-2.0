using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VolumeScript : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;  
  


    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Volume")) {
            PlayerPrefs.SetFloat("Volume", 100);
            Load();
        }

        else {
            Load();
        }
    }

    // Update is called once per frame
    void Update()
    {
        SetVolume();   
    }

    void SetVolume() 
    {
        AudioListener.volume = VolumeSlider.value;
        Save();
    }

    public void Save() {
        PlayerPrefs.SetFloat("Volume", VolumeSlider.value);
    }

    public void Load() {
        VolumeSlider.value = PlayerPrefs.GetFloat("Volume");
    }
}
