using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class PauseMan : MonoBehaviour
{
    public Canvas main;
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
            main.enabled = true;
            holder.alpha = 1f;
            holder.blocksRaycasts = true;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;

        }

        if (main.enabled || optionMenu.alpha == 1f) 
        {
            Time.timeScale = 0f;
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
