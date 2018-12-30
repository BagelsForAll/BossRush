using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSweep : MonoBehaviour
{

    public AudioClip clip;
    AudioSource audioSource;

    void Start()
    {
        PlaySweepAudio();
    }

    public void PlaySweepAudio()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(clip, 0.7F);
    }

}
