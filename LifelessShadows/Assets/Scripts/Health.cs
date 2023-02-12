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
        if (Input.anyKeyDown)
        {
            health -= 1;
            fill.value = health;
        }

        if (gameManager.reset = false && health <= 0)
        {
            gameManager.ResetGame();
        }

    }
    

}

