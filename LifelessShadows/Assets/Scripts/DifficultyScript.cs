using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DifficultyScript : MonoBehaviour
{
    public Slider diff;

    public enemySpawner enemySpawner;

    private int Ehard = 100;

    private int Emedium = 50;

    private int Eeasy = 25;


    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Difficulty")) {
            PlayerPrefs.SetFloat("Difficulty", 1);
            Load();
        }

        else {
            Load();
        }
    }

    // Update is called once per frame
    void Update()
    {
        setdiff();
    }

    void setdiff() 
    {
        if (diff.value == 1) {
            enemySpawner.numberOfEnemiesToSpawn = Eeasy;
        }
        else if (diff.value == 2) {
            enemySpawner.numberOfEnemiesToSpawn = Emedium;
        }
        else if (diff.value == 3) {
            enemySpawner.numberOfEnemiesToSpawn = Ehard;
        }
        Save();
    }

    public void Save() {
        PlayerPrefs.SetFloat("Difficulty", diff.value);
    }

    public void Load() {
        diff.value = PlayerPrefs.GetFloat("Difficulty");
    }
}
