using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.ThunderAndLightning;

public class LightningController : MonoBehaviour
{
    [SerializeField] LightningBoltPathScript lightning;

    public void SetLightningChaosFactor(float sliderValue)
    {
        lightning.ChaosFactor = sliderValue / 762;
    }

    public void SetLightningIntensity(float sliderValue)
    {
        lightning.Intensity = sliderValue / 15;
    }

}
