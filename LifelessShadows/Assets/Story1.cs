using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Story1 : MonoBehaviour
{
    public GameManager gameMan;
    public bool treeCollected = false;
    public PlayerDeathMan pDeathMan;
    public FadeInImage FadeInImage;

    void Start()
    {
      
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            StartCoroutine("Cut1");
        }
    }

    private IEnumerator Cut1()
    {
        Debug.Log("Cut1 started");
        FadeInImage.StartFadeIn();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Cut1");
    }



    private void OnTriggerEnter(Collider other)
    {
        // Nightmare Cutscene
        gameMan.story1Succeces = true;
        Debug.Log("Finished Story 1");
        //timelinedirector.Play();
    }
}
