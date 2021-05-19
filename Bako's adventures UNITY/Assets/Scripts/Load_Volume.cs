using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load_Volume : MonoBehaviour
{
    public AudioSource BGM;
    public AudioSource Shiba;
    public AudioSource Shiba_Alter;
    void Start()
    {
        VolumeData data = SaveSystem.LoadVolume();
        BGM.volume = data.MusicVolume;
        Shiba.volume = data.SoundVolume;
        Shiba_Alter.volume = data.SoundVolume;
    }
}
