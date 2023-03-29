using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class logbookSTART : MonoBehaviour
{
    public Canvas canvas;
    public int hasPickedUpBook;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("hasPickedUpBook"))
        {
            PlayerPrefs.SetInt("hasPickedUpBook", 0);
            Load();
        }
        else
        {
            Load();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hasPickedUpBook == 1) {
            Destroy(gameObject);
                }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            canvas.enabled = true;
            if (Input.GetKeyDown(KeyCode.T)) {
                hasPickedUpBook = 1;
                Destroy(gameObject);
                Save(); 
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (hasPickedUpBook == 1  && other.CompareTag("Player"))
        {
            canvas.enabled = false;
        }
    }

    public void Save()
    {
        if (hasPickedUpBook == 1)
        {
            PlayerPrefs.SetInt("hasPickedUpBook", 1);
        }
        else if ( hasPickedUpBook == 0)
        {
            PlayerPrefs.SetInt("hasPickedUpBook", 0);
        }
    }
    public void Load()
    {
        hasPickedUpBook = PlayerPrefs.GetInt("hasPickedUpBook");
    }
}
