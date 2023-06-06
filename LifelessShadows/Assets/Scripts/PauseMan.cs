using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMan : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject holder;
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

    public void back()
    {
        optionMenu.SetActive(false);
        holder.SetActive(true);
    }

    public void Options()
    {
        holder.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        optionMenu.SetActive(false);
    }
}
