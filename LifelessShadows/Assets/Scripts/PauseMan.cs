using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMan : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject optionMenu;
    // Start is called before the first frame update
    void Start()
    {
        optionMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backPressed()
    {
        optionMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
