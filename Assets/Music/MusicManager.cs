using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLooper : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip music1;
    public AudioClip music2;

    private void Start()
    {
        musicSource.clip = music1;
        musicSource.Play();
    }

    private void Update()
    {
        if (!musicSource.isPlaying)
        {
            musicSource.clip = music2;
            musicSource.loop = true;
            musicSource.Play();
        }
    }
}