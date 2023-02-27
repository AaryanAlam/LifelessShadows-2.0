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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("da");
    }

    public void OptionMenu()
    {
        optionMenu.SetActive(true);

    }

    public void QuitGame() => Application.Quit();
}
