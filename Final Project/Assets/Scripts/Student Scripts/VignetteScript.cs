using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.InputSystem;
using System;

public class VignetteScript : MonoBehaviour
{
    [SerializeField]    //Vignette duration and intensity with applied movement
    float intensity = 0.75f;
    [SerializeField]
    float duration = 0.5f;
    [SerializeField]
    private Volume volume;
    Vignette vignette;
    [SerializeField]
    InputActionReference continousMove;

    private void Awake()
    {
        continousMove.action.performed += FadeIn;   //Vignette actions for processing Fade procedure from player movement
        continousMove.action.canceled += FadeOut;

        if (volume.profile.TryGet(out Vignette vignette))
            this.vignette = vignette;
    }

    private void FadeOut(InputAction.CallbackContext obj)   //When player input is released, Vignette transitions off
    {
        StartCoroutine(Fade(0, intensity));
    }

    private void FadeIn(InputAction.CallbackContext obj)    //When player input is registered, Vignette transitions on
    {
        if (obj.ReadValue<Vector2>() != Vector2.zero)
        {
            StartCoroutine(Fade(intensity, 0));
        }
    }
    IEnumerator Fade(float starValue, float endValue)   //To start the Coroutines, making them able to fade in and out
    {
        float elapsedTime = 0.0f;
        float blend = elapsedTime / duration;
        float intensity = Mathf.Lerp(starValue, endValue, blend);
        ApplyValue(intensity);
        yield return null;
    }

    void ApplyValue(float value)    //Intensity for Vignette
    {
        vignette.intensity.Override(value);
    }
}
