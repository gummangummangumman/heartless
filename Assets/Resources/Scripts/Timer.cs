using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timestamp = 0;
    void Update()
    {
        timestamp += Time.deltaTime;
    }
}
