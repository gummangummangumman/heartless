using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreBeam : MonoBehaviour
{
    public GameObject lightbean;
    private float clock;
    void Update()
    {
        clock += Time.deltaTime;

        if (clock >= 1.7f)
            Destroy(lightbean);
    }
}