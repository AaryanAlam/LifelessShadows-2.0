using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMan2 : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionMenu;
    public GameObject game;
    public GameObject background;

    public Camera gameCam;
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        optionMenu.SetActive(false);
        game.SetActive(false);
        mainCam.enabled = true;
        gameCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startClicked()
    {
        Debug.Log("Start Pressed");
        background.SetActive(false);
        game.SetActive(true);
        optionMenu.SetActive(false);
        mainMenu.SetActive(false);
        mainCam.enabled = false;
        gameCam.enabled = true;
        Invoke("LockCurser", 0.5f);
    }

    public void optionPressed()
    {
        background.SetActive(true);
        optionMenu.SetActive(true);
        game.SetActive(false);
        mainMenu.SetActive(false);
        mainCam.enabled = true;
        gameCam.enabled = false;
    }

    public void backPressed()
    {
        background.SetActive(true);
        mainMenu.SetActive(true);
        game.SetActive(false);
        optionMenu.SetActive(false);
        mainCam.enabled = true;
        gameCam.enabled = false;
    }

    public void quitPressed()
    {
        Application.Quit();
    }

    public void LockCurser() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
