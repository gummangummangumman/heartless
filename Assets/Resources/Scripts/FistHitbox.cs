using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistHitbox : MonoBehaviour
{
    private float clock = 0;
    
    
    void Update()
    {
        clock += Time.deltaTime;

        if (clock < 0.5f)
            Destroy(gameObject);
    }
}
