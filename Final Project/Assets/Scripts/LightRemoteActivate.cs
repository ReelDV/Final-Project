using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightRemoteActivate : MonoBehaviour
{
    [SerializeField]
    Light RealLight;
    private XRGrabInteractable grabInteractable;
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(LightOn);   //Activates once trigger press is inputted
    }

    private void LightOn(ActivateEventArgs arg0)
    {
        RealLight.enabled = true;

    }

}
