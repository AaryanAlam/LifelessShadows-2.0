using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story1 : MonoBehaviour
{
    public GameManager gameMan;
    public bool treeCollected = false;
    public PlayerDeathMan pDeathMan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Nightmare Cutscene
        gameMan.story1Succeces = true;
        Debug.Log("FInished Story 1");
    }
}
