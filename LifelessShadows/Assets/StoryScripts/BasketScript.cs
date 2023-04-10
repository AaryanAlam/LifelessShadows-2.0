using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketScript : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject empty;

    // Start is called before the first frame update
    void Start()
    {
        //gameManager = GameObject.FindGameObjectWithTag("gameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Basket Collision");
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E");
            StartCoroutine(gameManager.WaitForFood(2, empty));
        }
    }
}
