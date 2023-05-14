using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Story1 : MonoBehaviour
{
    public GameManager gameMan;
    public bool treeCollected = false;
    public PlayerDeathMan pDeathMan;
    public GameObject timeline1;
    PlayableDirector timelinedirector;

    void Start()
    {
        timelinedirector = timeline1.GetComponent<PlayableDirector>();
        timelinedirector.stopped += OnTimelineStopped;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            timelinedirector.Play();
        }
    }
    void OnTimelineStopped(PlayableDirector director)
    {
        timelinedirector.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Nightmare Cutscene
        gameMan.story1Succeces = true;
        Debug.Log("Finished Story 1");
        //timelinedirector.Play();
    }
}
