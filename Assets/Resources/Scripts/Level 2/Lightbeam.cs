using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbeam : MonoBehaviour
{
    private float timer = 0;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2)
        {
            Destroy(this);
        }
    }
}
