using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapShotCollider : MonoBehaviour
{
    public AudioMixerSnapshot Day;
    public AudioMixerSnapshot Night;

    bool isNight = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (!isNight)
            {
                Night.TransitionTo(0.5f);
                isNight = true;
            }
            else if (isNight)
            {
                Day.TransitionTo(0.5f);
                isNight = false;
            }
        }
        
    }
}
