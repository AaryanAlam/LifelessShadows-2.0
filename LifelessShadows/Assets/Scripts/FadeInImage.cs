using UnityEngine;
using UnityEngine.UI;

public class FadeInImage : MonoBehaviour
{
    public float fadeDuration = 2f; // Duration of the fade in seconds

    private Image image;
    private CanvasRenderer canvasRenderer;
    private float currentAlpha = 0f;
    private float timer = 0f;
    private bool isFading = false;

    private void Start()
    {
        image = GetComponent<Image>();
        canvasRenderer = GetComponent<CanvasRenderer>();
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f); // Set initial alpha to 0
    }

    public void StartFadeIn()
    {
        if (isFading) return; // Don't start a new fade if one is already in progress

        isFading = true;
        timer = 0f;
        currentAlpha = 0f;
        image.color = new Color(image.color.r, image.color.g, image.color.b, currentAlpha);
        enabled = true; // Enable this script to start the fading process
    }

    private void Update()
    {
        if (!isFading) return; // Exit if not currently fading

        timer += Time.deltaTime;
        if (timer < fadeDuration)
        {
            currentAlpha = Mathf.Lerp(0f, 1f, timer / fadeDuration); // Calculate the new alpha value using Lerp
            image.color = new Color(image.color.r, image.color.g, image.color.b, currentAlpha); // Update the alpha value of the image color
        }
        else
        {
            currentAlpha = 1f; // Set the alpha to the final value (1 in this case)
            image.color = new Color(image.color.r, image.color.g, image.color.b, currentAlpha);
            isFading = false;
            enabled = false; // Disable this script
        }
    }
}
