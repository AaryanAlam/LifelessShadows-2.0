using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BasketScript : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject empty;
    public FPmovement player;
    public Slider foodSlider;
    

    private bool inTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        //gameManager = GameObject.FindGameObjectWithTag("gameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if Player presses E and is close enough
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
            gameManager.stomachFullness = 100;
            gameManager.Story1Done = true;
        }

        


        // Sets hunger bar to hunger variable
        foodSlider.value = gameManager.stomachFullness;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Checks if in trigger
        inTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        // Checks if not in trigger
        inTrigger = false;
    }

    
}
