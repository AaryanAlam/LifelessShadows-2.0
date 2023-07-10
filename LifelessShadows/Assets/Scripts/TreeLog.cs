using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLog : MonoBehaviour
{
    private GameManager gameManager;

    private bool trigger = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("started");
        gameManager = GameObject.FindObjectOfType<GameManager>();
        if (gameManager == null)
        {
            Debug.Log("Could not find GameManager object");
        }
        gameManager.LoadMatData();
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("R");
                DestroyTree();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        trigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        trigger = false;
    }

    public void DestroyTree()
    {
        Destroy(gameObject);
        switch(gameObject.name)
        {
            case "Treelog(Clone)":
                gameManager.tree += 8;
                break;
            case "Iron(Clone)":
                gameManager.iron += 3;
                break;
            case "Copper(Clone)":
                gameManager.copper += 4;
                break;
            case "SOG(Clone)":
                gameManager.SOG += 2;
                break;
            case "Platic(Clone)":
                gameManager.plastic += 6;
                break;
            case "Flint(Clone)":
                gameManager.flint += 5;
                break;
            case "Scrap(Clone)":
                gameManager.scrap += 7;
                break;
            case "Stone(Clone)":
                gameManager.stone += 8;
                break;
        }
        gameManager.SaveMatData();
    }


}
