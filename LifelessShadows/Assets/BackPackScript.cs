using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPackScript : MonoBehaviour
{
    private GameManager gameManager;
    private FPmovement fpmovement;

    public int fullness = 0;
    public bool carrying = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gameManager").GetComponent<GameManager>();
        fpmovement = GameObject.FindWithTag("Player").GetComponent<FPmovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fullness >= 10)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                fpmovement.stomachFullness += 10;
            }
        }
    }
}
