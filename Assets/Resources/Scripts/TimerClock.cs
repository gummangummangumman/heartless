using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerClock : MonoBehaviour
{
    public float timeDisplay = 0;

    void Update()
    {
        timeDisplay += Time.deltaTime;
    }
}