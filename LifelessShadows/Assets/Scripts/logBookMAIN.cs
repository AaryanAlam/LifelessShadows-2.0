using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class logBookMAIN : MonoBehaviour
{
    public logbookSTART logbookSTART;

    public Canvas logbookCanvas;

    public CanvasGroup invnetory;
    public CanvasGroup textPages;

    public TMP_Text myTextMeshPro1;
    public TMP_Text myTextMeshPro2;

    int currentPage1 = 1;
    int currentPage2 = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (logbookSTART.hasPickedUpBook == 1)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                logbookCanvas.enabled = !logbookCanvas.enabled;
            }
        }


        myTextMeshPro1.pageToDisplay = currentPage1;
        myTextMeshPro2.pageToDisplay = currentPage2;
        if (logbookCanvas.enabled == true)
        {
            Time.timeScale = 0f;
            if (Input.GetKeyDown (KeyCode.M)) 
            {

                invnetory.alpha = invnetory.alpha != 1f ? 1f : 0f;
                invnetory.blocksRaycasts = !invnetory.blocksRaycasts;
                textPages.alpha = textPages.alpha != 0f ? 0f : 1f;
                textPages.blocksRaycasts = !textPages.blocksRaycasts;

            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                currentPage1 += 2;
                currentPage2 += 2;
                if (currentPage1 >= 8)
                {
                    currentPage1 = 7;
                }
                if (currentPage2 >= 8)
                {
                    currentPage2 = 8;
                }

            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                currentPage1 -= 2;
                currentPage2 -= 2;
                if (currentPage1 <= 1)
                {
                    currentPage1 = 1;
                }
                if (currentPage2 <= 2)
                {
                    currentPage2 = 2;
                }
            }
        }
        else
        {
            Time.timeScale = 1f;
        }


    }
}
