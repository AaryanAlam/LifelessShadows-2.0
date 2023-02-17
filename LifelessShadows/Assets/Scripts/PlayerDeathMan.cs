using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathMan : MonoBehaviour
{
    public GameObject resetPoint;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void RestartPlayer()
    {
        SceneManager.LoadScene("da");
        transform.position = resetPoint.transform.position;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
