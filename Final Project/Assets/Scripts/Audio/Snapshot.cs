using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Snapshot : MonoBehaviour
{
    public AudioMixerSnapshot Day;
    public AudioMixerSnapshot Night;

    public AudioMixer ambience;
    public AudioMixerGroup birds;
    public AudioMixerGroup owls;

    public float transitionTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        Day = ambience.FindSnapshot("Day");
    }

    void OnPlayAudio()
    {
        Night.TransitionTo(transitionTime);
    }
}
