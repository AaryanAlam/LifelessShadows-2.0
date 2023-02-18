using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject resetPoint;
    public bool reset = false;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void ResetGame()
    {
        reset = true;
        Debug.Log("Getting to it");
        SceneManager.LoadScene("Dead Scene");
        gameObject.GetComponent<test>().enabled = true;
    }
}
