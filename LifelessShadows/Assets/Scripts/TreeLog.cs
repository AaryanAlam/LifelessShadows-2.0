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
        Debug.Log("Triggered");

        Debug.Log("Pressed");
        trigger = true;

    }

    public void DestroyTree()
    {
        Destroy(gameObject);
        gameManager.tree += 8;
    }


}
