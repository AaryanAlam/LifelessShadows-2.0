using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicScript : MonoBehaviour
{
    public AudioListener audioListener;
    public AudioSource musicAudioSource;
    public Slider musicSlider;

    private void Start()
    {
        // Set the initial value of the music slider
        musicSlider.value = musicAudioSource.volume;
    }

    public void UpdateMusicVolume()
    {
        // Update the volume of the Music Audio Source based on the value of the music slider
        musicAudioSource.volume = musicSlider.value;
    }
}
