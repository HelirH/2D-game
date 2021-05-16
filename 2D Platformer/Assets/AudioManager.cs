using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] soundeffects;
    public static AudioManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void PlayEffect(int soundFromList)
    {
        soundeffects[soundFromList].Play();
    }
}
