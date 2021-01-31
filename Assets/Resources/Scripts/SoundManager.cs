using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        GameObject progressTracker = GameObject.Find("ProgressTracker");
        if (progressTracker)
            audioSource.volume = progressTracker.GetComponent<ProgressTracker>().GetVolume();
        else
            audioSource.volume = 0.5f;

    }
    
}
