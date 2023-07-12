using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class PauseMan : MonoBehaviour
{
    public Canvas main;
    public MainMenuMan2 MainMenuMan2;
    public GameObject mainmenuBackground;
    public CanvasGroup holder;
    public CanvasGroup optionMenu;
    public bool fromPause;
    // Start is called before the first frame update
    void Start()
    {
        main.enabled = false;
        fromPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Time.timeScale = 0f;

            main.enabled = !main.enabled;
            holder.alpha = holder.alpha != 1f ? 1f : 0f;
            holder.blocksRaycasts = !holder.blocksRaycasts;
            Cursor.lockState = CursorLockMode.Confined ? CursorLockMode ;
            Cursor.visible = !Cursor.visible;

        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void back()
    {
        main.enabled = false;
        holder.alpha = 0f;
        holder.blocksRaycasts = false;
    }

    public void Options()
    {
        holder.alpha = 0f;
        holder.blocksRaycasts = false;
        MainMenuMan2.mainCam.enabled = true;
        MainMenuMan2.gameCam.enabled = false;
        MainMenuMan2.game.SetActive(false);
        optionMenu.alpha = 1f;
        optionMenu.blocksRaycasts = true;
        mainmenuBackground.SetActive(true);
        fromPause = true;
    }

    public void Resume()
    {
        main.enabled = false;
        holder.alpha = 0f;
        holder.blocksRaycasts = false;

    }

}
