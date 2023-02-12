using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject resetPoint;
    public bool reset = false;

    public void ResetGame()
    {
        player.transform.position = resetPoint.transform.position;
        reset = true;
    }
}
