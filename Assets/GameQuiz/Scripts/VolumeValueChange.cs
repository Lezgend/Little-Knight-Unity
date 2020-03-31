using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValueChange : MonoBehaviour
{
    public Slider musicVolumeSlider;
    private AudioSource audioSrc;

    //public Slider effectsVolumeSlider;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        musicVolumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        //effectsVolumeSlider.value = PlayerPrefs.GetFloat("EffectsVolume", 0.75f);
    }

    void Update()
    {
        audioSrc.volume = musicVolumeSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", audioSrc.volume);

    }

    //public void updateMusicVolume()
    //{
    //    PlayerPrefs.SetFloat("MusicVolume", audioSrc.volume);
    //}

    //public void updateEffectsVolume()
    //{
    //    PlayerPrefs.SetFloat("EffectsVolume", effectsVolumeSlider.value);

    //}
}
