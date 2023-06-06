using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    private GameObject objectToParent;
    private bool collected = false;
    public Transform childParent;

    private void Start()
    {
        objectToParent = GameObject.Find("Object"); // Find the object you want to parent
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (objectToParent != null && collected)
            {
                objectToParent.transform.SetParent(childParent);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Object")
        {
            objectToParent = other.gameObject;
            collected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Object")
        {
            collected = false;
        }
    }
}
