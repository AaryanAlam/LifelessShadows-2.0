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
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entered Cap");
            gameManager.inTree = true;
            Debug.Log("TreeLog - L27 - inTree");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        gameManager.inTree = false;
    }

    public void DestroyObject()
    {
        StartCoroutine(Wait());
        Destroy(gameObject);
        gameManager.inTree = false;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
        
    }

    
}
