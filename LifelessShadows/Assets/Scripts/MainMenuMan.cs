using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMan : MonoBehaviour
{
    private GameObject optionMenu;
    private GameObject mainMenu;

    // Start is called before the first frame update
    void Start()
    {
        optionMenu = GameObject.FindWithTag("OptionMenu");
        mainMenu = GameObject.FindWithTag("mainMenu");
        optionMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Debug.Log("Start Pressed");
        SceneManager.LoadScene("da");
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
