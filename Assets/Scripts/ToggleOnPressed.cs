using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToggleOnPressed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ToggleMenu()
    {

        gameObject.SetActive(!gameObject.activeSelf);
    }
}
