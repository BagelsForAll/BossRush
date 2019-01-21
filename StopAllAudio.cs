using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAllAudio : MonoBehaviour
{
    public void Awake()
    {
        AudioListener.pause = true;
    }
}