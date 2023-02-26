using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject resetPoint;
    public TreeLog treeLog;
    public bool reset = false;
    public bool inTree = false;


    public float tree;
    public Text treeText;

    private void Start()
    {
        tree = 0.0f;
        player = GameObject.FindWithTag("Player");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && inTree)
        {
            treeLog.DestroyObject();
            AddTree(8);
        }
        treeText.text = tree.ToString();
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
    }

    public void RemoveTree(float AmountOfTree)
    {
        tree -= AmountOfTree;
    }
}
