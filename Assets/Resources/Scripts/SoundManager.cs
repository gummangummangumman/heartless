using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = GameObject.Find("ProgressTracker").GetComponent<ProgressTracker>().GetVolume();
    }
    
}
