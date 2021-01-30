using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTurrets : MonoBehaviour
{
    private float clock = 0;
    private float speed = 6;
    public GameObject LEye;
    public GameObject REye;
    Vector2 originalPosREye;
    Vector2 originalPosLEye;
    private Vector2 Offset;
    private bool RightActive;
    private bool LeftActive;

    void Start()
    {
        originalPosLEye = LEye.transform.position;
        originalPosREye = REye.transform.position;

        Offset = Vector2.up * 2.536f;
    }

    void Update()
    {
        clock += Time.deltaTime;

        if (RightActive)
            REye.transform.position = Vector3.MoveTowards(REye.transform.position, originalPosREye + Offset, speed * Time.deltaTime);
        else REye.transform.position = Vector3.MoveTowards(REye.transform.position, originalPosREye, speed * Time.deltaTime);

        if (LeftActive)
            LEye.transform.position = Vector3.MoveTowards(LEye.transform.position, originalPosLEye + Offset, speed * Time.deltaTime);
        else LEye.transform.position = Vector3.MoveTowards(LEye.transform.position, originalPosLEye, speed * Time.deltaTime);


        if (clock > 5 && clock < 6)
            RightActive = true;

        if (clock > 20 && clock < 21)
        {
            RightActive = false;
            LeftActive = true;
        }

        if (clock > 40 && clock < 41)
        {
            LeftActive = false;
            RightActive = true;
        }
    }
}
