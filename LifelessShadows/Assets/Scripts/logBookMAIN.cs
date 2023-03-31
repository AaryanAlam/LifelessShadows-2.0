using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class logBookMAIN : MonoBehaviour
{
    public logbookSTART logbookSTART;

    public Canvas logbookCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (logbookSTART.hasPickedUpBook == 1) {
            if (Input.GetKeyDown(KeyCode.T))
            {
                logbookCanvas. enabled = !logbookCanvas.enabled;
            }
        }
    }
}
