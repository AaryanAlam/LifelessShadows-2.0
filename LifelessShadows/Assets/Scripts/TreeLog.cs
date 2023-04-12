using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLog : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Checks if player in Collider
        if (other.CompareTag("Player"))
        {
            gameManager.inTree = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        gameManager.inTree = false;
    }

    public void DestroyObject()
    {
        // Destroys TreeLog if called
        StartCoroutine(Wait());
        Destroy(gameObject);
        gameManager.inTree = false;
    }

    IEnumerator Wait()
    {
        // Waits
        yield return new WaitForSeconds(2f);
        
    }

    
}
