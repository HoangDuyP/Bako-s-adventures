using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class VolumeData
{
    public float MusicVolume = 0.2f;
    public float SoundVolume = 0.4f;
    public VolumeData(float music, float sound)
    {
        MusicVolume = music;
        SoundVolume = sound;
    }
}
