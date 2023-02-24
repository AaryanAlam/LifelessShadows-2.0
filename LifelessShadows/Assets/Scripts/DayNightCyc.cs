using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCyc : MonoBehaviour
{
    public Material[] skyboxMaterials;
    public float changeInterval = 1440f; // 24 minutes in seconds
    public float blendDuration = 1440f; // 24 min to blend between skyboxes

    private int currentSkyboxIndex = 0;
    private Material targetSkyboxMaterial;

    void Start()
    {
        RenderSettings.skybox = skyboxMaterials[currentSkyboxIndex];
        StartCoroutine(ChangeSkybox());
    }

    IEnumerator ChangeSkybox()
    {
        while (true)
        {
            int nextSkyboxIndex = (currentSkyboxIndex + 1) % skyboxMaterials.Length;
            targetSkyboxMaterial = skyboxMaterials[nextSkyboxIndex];

            float elapsedTime = 0f;
            while (elapsedTime < blendDuration)
            {
                RenderSettings.skybox.Lerp(RenderSettings.skybox, targetSkyboxMaterial, elapsedTime / blendDuration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            RenderSettings.skybox = targetSkyboxMaterial;
            currentSkyboxIndex = nextSkyboxIndex;
            yield return new WaitForSeconds(changeInterval - blendDuration);
        }
    }
}
