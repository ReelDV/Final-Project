using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RemoteActivate : MonoBehaviour
{
    [SerializeField]
    GameObject Green;
    private XRGrabInteractable grabInteractable;
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(TVOn);   //Activates once trigger press is inputted
    }

    private void TVOn(ActivateEventArgs arg0)
    {
        Green.SetActive(true);  //Green panel appears once trigger is pressed with the remote

    }

}
