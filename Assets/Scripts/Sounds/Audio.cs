using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayerScript : MonoBehaviour
{
    public AudioClip sound1; // First audio clip
    public AudioClip sound2; // Second audio clip
    public AudioClip sound3; // Third audio clip
    public AudioClip sound4; // Fourth audio clip

    public AudioSource audioSource;// Reference to the AudioSource component

    void Start()
    {
        
    }

    public void PlaySound1()
    {
        audioSource.clip = sound1;
        audioSource.Play();
    }

    public void PlaySound2()
    {
        audioSource.clip = sound2;
        audioSource.Play();
    }

    public void PlaySound3()
    {
        audioSource.clip = sound3;
        audioSource.Play();
    }

    public void PlaySound4()
    {
        audioSource.clip = sound4;
        audioSource.Play();
    }
}