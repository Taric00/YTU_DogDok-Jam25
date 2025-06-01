using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings_Menu_Manager : MonoBehaviour
{
    public Slider masterVol, musicVol, sfxVol;
    public AudioMixer _mainAudioMixer;


    public void ChangeMasterVolume()
    {
        _mainAudioMixer.SetFloat("Master", masterVol.value);
    }
    
    public void ChangeMusicVolume()
    {
        _mainAudioMixer.SetFloat("Music", masterVol.value);
    }
    public void ChangeSFXVolume()
    {
        _mainAudioMixer.SetFloat("SFX", masterVol.value);
    }
}
