using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionMenu : MonoBehaviour
{
    public Slider MusicSlider;
    public Slider SoundSlider;
    public float music = 0.2f;
    public float sound = 0.4f;
    public void Start()
    {
        LoadVolume();
        AdjustSlider();
    }
    private void AdjustSlider()
    {
        MusicSlider.value = music;
        SoundSlider.value = sound;
    }
    private void LoadVolume()
    {
        VolumeData data = SaveSystem.LoadVolume();
        if (data != null)
        {
            music = data.MusicVolume;
            sound = data.SoundVolume;
        }
    }
    public void AdjustMusic(float volumeM)
    {
        music = volumeM;
    }
    public void AdjustSound(float volumeS)
    {
        sound = volumeS;
    }
    public void Confirm()
    {
        SaveSystem.SaveVolume(music, sound);
    }
}
