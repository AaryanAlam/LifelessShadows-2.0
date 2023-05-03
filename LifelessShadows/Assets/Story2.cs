using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story2 : MonoBehaviour
{
    public GameObject puzzleTree;
    private Vector3 originalTreePos;
    public bool test = false;
    private bool inTrigger = false;


    // Start is called before the first frame update
    void Start()
    {
        if (puzzleTree == null)
        {
            Debug.LogError("puzzleTree = null");
        }
        originalTreePos = puzzleTree.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // if player has axe
        if (test && inTrigger && Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.N))
        {
            // Tree animation
            // Spawn Bottom
            puzzleTree.transform.rotation = Quaternion.Euler(puzzleTree.transform.rotation.x, puzzleTree.transform.rotation.y, 80);
        }
    }
}
