using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Alessandro Napoli

public class VolumeSetting : MonoBehaviour
{
    [SerializeField] private Slider soundVolumeSlider = null;
    [SerializeField] private Slider musicVolumeSlider = null;
    [SerializeField] private TMP_Text soundVolumeTextUI = null;
    [SerializeField] private TMP_Text musicVolumeTextUI = null;
    public void MusicVolumeSlider(float volume)
    {
        musicVolumeTextUI.text = volume.ToString("0");
    }

    public void SoundVolumeSlider(float volume)
    {
        soundVolumeTextUI.text = volume.ToString("0");
    }
}