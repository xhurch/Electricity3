using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using AudioHelm;

public class ArpBassControl : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;

    // Start is called before the first frame update
    public void SetCutoff(float sliderValue)
    {
        audioMixer.SetFloat("cutoff", sliderValue);
    }
    public void SetDistortionDrive(float sliderValue)
    {
        audioMixer.SetFloat("distortionDrive", sliderValue);
    }

}
