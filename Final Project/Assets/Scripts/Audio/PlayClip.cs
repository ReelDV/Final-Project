using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClip : MonoBehaviour
{
    public AudioSource audioPlay;
    public AudioClip Enter;

    private void OnTriggerEnter(Collider other)
    {
        audioPlay.clip = Enter;
        audioPlay.Play();
    }
}
