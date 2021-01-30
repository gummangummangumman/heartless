using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbeam : MonoBehaviour
{
    public GameObject bean;
    private float clock;
    void Update()
    {
        clock += Time.deltaTime;

        if (clock >= 1.2f)
            Destroy(bean);
    }
}
