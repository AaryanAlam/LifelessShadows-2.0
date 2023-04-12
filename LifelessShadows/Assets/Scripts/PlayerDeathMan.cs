using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathMan : MonoBehaviour
{
    public GameObject resetPoint;

    private void Awake()
    {
        // Locks Cursor and turns it on
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void RestartPlayer()
    {
        // Restarts player to original position and unlocks cursor
        SceneManager.LoadScene("da");
        transform.position = resetPoint.transform.position;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
