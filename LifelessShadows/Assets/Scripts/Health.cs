using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public Slider fill;
    public int health = 100;
    public GameObject playerPrefab;
    public GameObject spawn;
    public GameManager gameManager;

    private void Awake()
    {
        health = 100;
    }

    private void Update()
    {
        fill.value = health;

        if (health <= 0)
        {
            Debug.Log("Went through");
            gameManager.ResetGame();
        }

    }
    

}

