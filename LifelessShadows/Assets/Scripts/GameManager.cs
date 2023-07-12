using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject resetPoint;
    public Story1 story1;
    public MainMenuMan2 menuMan;
    public bool reset = false;
    public bool inTree = false;
    private ParticleSystem Psystem;
    public BasketScript basket;
    public GameObject story1trig;
    public int stomachFullness = 8;
    public Health health;
    public int maxDetuct = 3;
    public float time = 60.0f;
    public float timeH = 10.0f;
    public float timeTree = 5.0f;
    bool startTreeTimer = false;

    public bool story1Succeces = false;
    public bool Story1Done = false;


    public float tree;
    public float iron;
    public float plastic;
    public float stone;
    public float flint;
    public float scrap;
    public float copper;
    public float SOG;
    public Text treeText;
    public Text ironText;
    public Text plasticText;
    public Text stoneText;
    public Text flintText;
    public Text scrapText;
    public Text copperText;
    public Text SOGText;
    //public Text foodText;

    public void Start()
    {
        LoadResourceData();
        LoadMatData();

        player = GameObject.FindWithTag("Player");
        //foodText.text = stomachFullness.ToString();
        story1trig.SetActive(false);

        StartCoroutine(healthNeed());
    }



    public void Update()
    {
        // Sets food Text to hunger variable
        //foodText.text = stomachFullness.ToString();

        treeText.text = tree.ToString();
        ironText.text = iron.ToString();
        plasticText.text = plastic.ToString();
        stoneText.text = stone.ToString();
        flintText.text = flint.ToString();
        scrapText.text = scrap.ToString();
        copperText.text = copper.ToString();
        SOGText.text = SOG.ToString();


        // Sets Tree text
        

        // Admin Command Resets Tree
        if (Input.GetKeyDown(KeyCode.Y))
        {
            tree = 0;
        }
        

        time -= Time.deltaTime;



        if (time <= 0)
        {
            timerEnded();
        }

        if (Story1Done)
        {
            story1trig.SetActive(true);
        }

    }

    public void ResetGame()
    {
        // Kills player and resets game
        reset = true;
        SceneManager.LoadScene("Dead Scene");
        //gameObject.GetComponent<test>().enabled = true;
    }

    public void AddTree(float AmountOfTree)
    {
        // Adds tree
        tree += AmountOfTree;
        SaveResourceData();
    }

    public void RemoveTree(float AmountOfTree)
    {
        // Removes tree
        tree -= AmountOfTree;
        SaveResourceData();
    }

    public void SaveResourceData()
    {
        PlayerPrefs.SetFloat("TreeLogs", tree);
    }

    public void SaveMatData()
    {
        PlayerPrefs.SetFloat("TreeLogs", tree);
        PlayerPrefs.SetFloat("Scrap", scrap);
        PlayerPrefs.SetFloat("Iron", iron);
        PlayerPrefs.SetFloat("Platic", plastic);
        PlayerPrefs.SetFloat("Copper", copper);
        PlayerPrefs.SetFloat("Flint", flint);
        PlayerPrefs.SetFloat("Stone", stone);
        PlayerPrefs.SetFloat("SOG", SOG);
    }

    public void LoadMatData()
    {
        tree = PlayerPrefs.GetFloat("TreeLogs", tree);
        scrap = PlayerPrefs.GetFloat("Scrap", scrap);
        iron = PlayerPrefs.GetFloat("Iron", iron);
        plastic = PlayerPrefs.GetFloat("Platic", plastic);
        copper =PlayerPrefs.GetFloat("Copper", copper);
        flint = PlayerPrefs.GetFloat("Flint", flint);
        stone = PlayerPrefs.GetFloat("Stone", stone);
        SOG = PlayerPrefs.GetFloat("SOG", SOG);
    }



    public void LoadResourceData()
    {
        tree = PlayerPrefs.GetFloat("TreeLogs");
    }
    



    IEnumerator healthNeed()
    {
        while (true)
        {
            if (stomachFullness <= 0)
            {
                health.health -= Random.Range(0, 3);
            }

            yield return new WaitForSeconds(1f);
        }
    }

    public void timerEnded()
    {
        time = 60;
        stomachFullness -= Random.Range(0, maxDetuct);
    }

    

    public void Nightmare(int i)
    {
        switch (i)
        {
            case 0:
                break;
            case 1:
                // Sleep Animation
                // Nightmare Cutscene
                health.health = 100;
                stomachFullness = 100;
                // Cutscene
                // Spawn Location & Rotation
                break;
            case 2:
                // Sleep Animation
                // Nightmare Cutscene
                health.health = 100;
                stomachFullness = 100;
                // Cutscene
                // Spawn Location & Rotation
                break;
            case 3:
                // Sleep Animation
                // Nightmare Cutscene
                health.health = 100;
                stomachFullness = 100;
                // Cutscene
                // Spawn Location & Rotation
                break;
            case 4:
                // Sleep Animation
                // Nightmare Cutscene
                health.health = 100;
                stomachFullness = 100;
                // Cutscene
                // Spawn Location & Rotation
                break;
            case 5:
                // Sleep Animation
                // Nightmare Cutscene
                health.health = 100;
                stomachFullness = 100;
                // Cutscene
                // Spawn Location & Rotation
                break;
            case 6:
                // Sleep Animation
                // Nightmare Cutscene
                health.health = 100;
                stomachFullness = 100;
                // Cutscene
                // Spawn Location & Rotation
                break;




        }
    }


}
