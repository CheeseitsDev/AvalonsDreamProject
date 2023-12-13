using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

//Alessandro Napoli

public class MasterVolume : MonoBehaviour
{
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider soundSlider;
    [SerializeField] AudioMixer masterMixer;
    private void Start()
    {
        SetMusicVolume(PlayerPrefs.GetFloat("SavedMusicVolume", 100));
        SetSoundVolume(PlayerPrefs.GetFloat("SavedSoundVolume", 100));
    }

    public void SetMusicVolume(float _value)
    {
        if (_value < 1) {
            _value = .001f;
        }
        RefreshMusicSlider(_value);
        PlayerPrefs.SetFloat("SaveMusicVolume", _value);
        masterMixer.SetFloat("MusicVolume", Mathf.Log10(_value / 100) * 20f);
    }

    public void SetSoundVolume(float _value)
    {
        if (_value < 1) {
            _value = .001f;
        }
        RefreshSoundSlider(_value);
        PlayerPrefs.SetFloat("SaveSoundVolume", _value);
        masterMixer.SetFloat("SoundVolume", Mathf.Log10(_value / 100) * 20f);
    }

    public void SetMusicVolumeFromSLider()
    {
        SetMusicVolume(musicSlider.value);
    }

    public void SetSoundVolumeFromSLider()
    {
        SetSoundVolume(soundSlider.value);
    }

    public void RefreshMusicSlider(float _value)
    {
        musicSlider.value = _value;
    }

    public void RefreshSoundSlider(float _value)
    {
        soundSlider.value = _value;
    }

    public void SaveChanges()
    {
        PlayerPrefs.Save();

        Debug.Log("Saved");
    }
}
