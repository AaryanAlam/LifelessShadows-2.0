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
        // Saving Volume for next Time in Settings
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
        // Checks Volume and Assigns it
        SetVolume();   
    }

    void SetVolume() 
    {
        AudioListener.volume = VolumeSlider.value;
        Save();
    }

    // Saves The volume
    public void Save() {
        PlayerPrefs.SetFloat("Volume", VolumeSlider.value);
    }

    // Loads Volume
    public void Load() {
        VolumeSlider.value = PlayerPrefs.GetFloat("Volume");
    }
}
