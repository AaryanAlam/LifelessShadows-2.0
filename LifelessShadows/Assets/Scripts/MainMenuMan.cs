using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMan : MonoBehaviour
{
    public GameObject gameHolder;

    public GameObject mainMenu;
    public GameObject optionMenu;
    // Start is called before the first frame update
    void Start()
    {
        gameHolder.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        gameHolder.SetActive(true);
        Debug.Log("Start Pressed");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OptionMenu()
    {
        optionMenu.SetActive(true);
        mainMenu.SetActive(false);
        Debug.Log("Option Pressed");
    }

    public void BackOption()
    {
        mainMenu.SetActive(true);
        optionMenu.SetActive(false);
    }

    public void QuitGame() => Application.Quit();
}
