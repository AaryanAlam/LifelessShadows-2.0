using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainMenuMan2 : MonoBehaviour
{
    public CanvasGroup mainMenu;
    public CanvasGroup optionMenu;
    public GameObject game;
    public GameObject background;

    public GameObject Music;


    public GameManager manager;

    public PauseMan pauseMan;

    public DifficultyScript difficulty;

    public VolumeScript volume;
    public Camera gameCam;
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        volume.Load();
        difficulty.Load();
        difficulty.setdiff();
        manager.LoadResourceData();
        mainMenu.alpha = 1;
        mainMenu.blocksRaycasts = true;
        optionMenu.alpha = 0;
        optionMenu.blocksRaycasts = false;
        game.SetActive(false);
        mainCam.enabled = true;
        gameCam.enabled = false;
        musicOn();

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
        optionMenu.alpha = 0;
        optionMenu.blocksRaycasts = false;
        mainMenu.alpha = 0;
        mainMenu.blocksRaycasts = false;
        mainCam.enabled = false;
        gameCam.enabled = true;
        Invoke("LockCurser", 0.5f);
        manager.LoadResourceData();
        Debug.Log(manager.tree);
        musicOff();
    }

    public void optionPressed()
    {
        background.SetActive(true);
        optionMenu.alpha = 1;
        optionMenu.blocksRaycasts = true;
        game.SetActive(false);
        mainMenu.alpha = 0;
        mainMenu.blocksRaycasts = false;
        mainCam.enabled = true;
        gameCam.enabled = false;
    }

    public void backPressed()
    {
        if (pauseMan.fromPause == true)
        {
            pauseMan.fromPause = false;
            pauseMan.main.enabled = true;
            pauseMan.holder.alpha = 1f;
            pauseMan.holder.blocksRaycasts = true;
            optionMenu.alpha = 0f;
            optionMenu.blocksRaycasts = false;
            background.SetActive(false);
            game.SetActive(true);
            mainCam.enabled = false;
            gameCam.enabled = true;
        }
        else if (pauseMan.fromPause == false)
        {
            background.SetActive(true);
            mainMenu.alpha = 1;
            mainMenu.blocksRaycasts = true;
            game.SetActive(false);
            optionMenu.alpha = 0;
            optionMenu.blocksRaycasts = false;
            mainCam.enabled = true;
            gameCam.enabled = false;
            musicOn();
        }
    }

    public void quitPressed()
    {
        Application.Quit();
        manager.SaveResourceData();
        volume.Save();
        difficulty.Save();
    }

    public void LockCurser() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void musicOff() {
        Music.SetActive(false);
    }
    public void musicOn() {
        Music.SetActive(true);
    }
}
