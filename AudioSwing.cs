using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSwing : MonoBehaviour {

    public AudioClip clip;
    AudioSource audioSource;

    void Start()
    {
        PlaySwingAudio();
    }

    public void PlaySwingAudio ()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(clip, 0.5F);
    }

}
