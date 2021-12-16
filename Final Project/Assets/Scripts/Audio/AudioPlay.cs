using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource audioPlay;
    public AudioClip Enter;
    public AudioClip Exit;

    private void OnTriggerEnter(Collider other)
    {
        audioPlay.clip = Enter;
        audioPlay.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        audioPlay.clip = Exit;
        audioPlay.Play();
    }
}
