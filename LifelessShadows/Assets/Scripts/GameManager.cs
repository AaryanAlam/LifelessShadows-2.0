using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject resetPoint;
    public Story1 story1;
    public MainMenuMan2 menuMan;
    public TreeLog treeLog;
    public bool reset = false;
    public bool inTree = false;
    private ParticleSystem Psystem;
    public BasketScript basket;
    public int stomachFullness = 8;
    public Health health;
    public int maxDetuct = 3;
    public float time = 5.0f;


    public float tree;
    public Text treeText;
    public Text foodText;

    public void Start()
    {
        Psystem = treeLog.GetComponent<ParticleSystem>();
        LoadResourceData();
        
        player = GameObject.FindWithTag("Player");
        foodText.text = stomachFullness.ToString();

        StartCoroutine(healthNeed());
    }



    public void Update()
    {
        // Sets food Text to hunger variable
        foodText.text = stomachFullness.ToString();

        if (Input.GetKeyDown(KeyCode.E) && inTree)
        {
            StartCoroutine(WaitForTree(1));
        }

        // Goes to Menu
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            menuMan.backPressed();
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        // Sets Tree text
        treeText.text = tree.ToString();

        // Admin Command Resets Tree
        if (Input.GetKeyDown(KeyCode.Y))
        {
            tree = 0;
        }

        if (tree == 16)
        {
            story1.treeCollected = true;
            tree++;
        }

        time -= Time.deltaTime;
        Debug.Log(time);

        if (time <= 0)
        {
            timerEnded();
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

    public void LoadResourceData()
    {
        tree = PlayerPrefs.GetFloat("TreeLogs");
    }
    IEnumerator WaitForTree(float i)
    {
        // Starts Particles and waits for some time then adds tree
        Psystem.Play();
        yield return new WaitForSecondsRealtime(i);
        treeLog.DestroyObject();
        AddTree(8);
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
        // Health go down timer
        Debug.LogWarning("Timer Ended");
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
