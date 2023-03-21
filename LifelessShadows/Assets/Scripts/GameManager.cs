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

    public float tree;
    public Text treeText;

    public void Start()
    {
        Psystem = treeLog.GetComponent<ParticleSystem>();
        LoadResourceData();

        player = GameObject.FindWithTag("Player");
    }

    public void Update()
    {
        if (inTree == true)
        {
            Debug.Log("intree1");
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && inTree)
        {
            StartCoroutine(WaitForTree(1));
        }
        if (inTree == true)
        {
            Debug.Log("intree2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            menuMan.backPressed();
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
        treeText.text = tree.ToString();
        if (inTree == true)
        {
            Debug.Log("intree3");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            tree = 0;
        }
        if (inTree == true)
        {
            Debug.Log("intree4");
        }
        if (tree == 16)
        {
            Debug.Log("Tree = 16");
            story1.treeCollected = true;
            tree++;
        }
        if (inTree == true)
        {
            Debug.Log("intree5");
        }

    }

    public void ResetGame()
    {
        reset = true;
        Debug.Log("Getting to it");
        SceneManager.LoadScene("Dead Scene");
        //gameObject.GetComponent<test>().enabled = true;
    }

    public void AddTree(float AmountOfTree)
    {
        tree += AmountOfTree;
        SaveResourceData();
    }

    public void RemoveTree(float AmountOfTree)
    {
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
        Psystem.Play();
        yield return new WaitForSecondsRealtime(i);
        treeLog.DestroyObject();
        AddTree(8);
        Debug.Log("Tree Chopped");
    }
}
