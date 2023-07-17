using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutImage : MonoBehaviour
{

    public float fadeDuration = 3f; // Duration of the fade in seconds

    private Image image;
    private CanvasRenderer canvasRenderer;
    private float currentAlpha = 1f;
    private float timer = 0f;
    private bool isFading = false;

    private void Start()
    {
        image = GetComponent<Image>();
        canvasRenderer = GetComponent<CanvasRenderer>();
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1f); // Set initial alpha to 0
    }

    public void StartFadeIn()
    {
        if (isFading) return; // Don't start a new fade if one is already in progress
        image.enabled = true;
        isFading = true;
        timer = 1f;
        currentAlpha = 1f;
        image.color = new Color(image.color.r, image.color.g, image.color.b, currentAlpha);
        enabled = true; // Enable this script to start the fading process
    }

    private void Update()
    {
        if (!isFading) return; // Exit if not currently fading

        timer += Time.deltaTime;
        if (timer < fadeDuration)
        {
            currentAlpha = Mathf.Lerp(1f, 0f, timer / fadeDuration); // Calculate the new alpha value using Lerp
            image.color = new Color(image.color.r, image.color.g, image.color.b, currentAlpha); // Update the alpha value of the image color
        }
        else
        {
            currentAlpha = 0f; // Set the alpha to the final value (1 in this case)
            image.color = new Color(image.color.r, image.color.g, image.color.b, currentAlpha);
            isFading = false;
            enabled = false; // Disable this script
        }
        if (timer > fadeDuration)
        {
            image.enabled = false;
        }
    }
}
