using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class SoundSet
{
    public string name;
    public AudioClip clip;

    public float volume;
    public bool loop;

    public AudioSource source;
}
