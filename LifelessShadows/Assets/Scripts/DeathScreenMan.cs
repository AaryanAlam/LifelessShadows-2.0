using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class DeathScreenMan : MonoBehaviour
{
    public TMP_Text text;
    private TMP_Text m_TextComponent;
    public string deathMessage;

    void Start()
    {
        
    }

    private void Awake()
    {
        string[] deathMessages = { "Condemned to the Beyond", "Haunting Memories", "Torn from Life", "Silent Passage", "The Wraith's Embrace", "Echoes of the Dead", "Buried in the Unknown", "The Other Side Beckons", "Forsaken to the Shadows", "Shattered Reality", "Beyond the Pale", "Chained to the Afterlife", "Fading into Nothingness", "The Last Rites", "Whispers in the Dark" };
        int rndIndex = UnityEngine.Random.Range(0, deathMessages.Length);
        m_TextComponent = GetComponent<TMP_Text>();
        deathMessage = deathMessages[rndIndex];
        m_TextComponent.text = deathMessage;
        text.text = deathMessage;
        Debug.Log("Index was: " + rndIndex + " Text Message was: " + m_TextComponent.text);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;

    }

    // Update is called once per frame
    void Update()
    {
        text.text = deathMessage;

    }
}
