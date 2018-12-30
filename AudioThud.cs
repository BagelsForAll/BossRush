using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioThud : MonoBehaviour
{

    public AudioClip clip;
    AudioSource audioSource;

    void Start()
    {
        PlayThudAudio();
    }

    public void PlayThudAudio()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(clip, 1F);
    }

}
