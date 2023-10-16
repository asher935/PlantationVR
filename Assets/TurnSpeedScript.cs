using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class TurnSpeedScript : MonoBehaviour
{
    [SerializeField] float turnSpeed;

    [SerializeField] Slider slider;
    [SerializeField] ActionBasedContinuousTurnProvider turnProvider;
    // Start is called before the first frame update
    void Start()
    {
       turnProvider = gameObject.GetComponent<ActionBasedContinuousTurnProvider>();
    }

    // Update is called once per frame
    void Update()
    {
        turnProvider.turnSpeed = slider.value;
    }
}
