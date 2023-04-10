using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story1 : MonoBehaviour
{
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
        if (treeCollected) 
        {
            Debug.Log("Tree Collected");
            // Nightmare Animation
            //pDeathMan.RestartPlayer();
            Debug.Log("Story1 Done");
        }
    }
}
