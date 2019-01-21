using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCharge : MonoBehaviour
{

    public AudioClip charge;
    AudioSource audioSource;

    void Start()
    {
        PlayFinalAttack();
    }

    public void PlayFinalAttack()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(charge, 0.7f);
    }
}