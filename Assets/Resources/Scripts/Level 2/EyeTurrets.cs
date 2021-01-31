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
    private bool rightactive;
    private bool leftactive;

    void Start()
    {
        originalPosLEye = LEye.transform.position;
        originalPosREye = REye.transform.position;

        Offset = Vector2.up * 2.536f;
    }

    void Update()
    {
        clock += Time.deltaTime;

        if (rightactive)
            REye.transform.position = Vector3.MoveTowards(REye.transform.position, originalPosREye + Offset, speed * Time.deltaTime);
        else REye.transform.position = Vector3.MoveTowards(REye.transform.position, originalPosREye, speed * Time.deltaTime);

        if (leftactive)
            LEye.transform.position = Vector3.MoveTowards(LEye.transform.position, originalPosLEye + Offset, speed * Time.deltaTime);
        else LEye.transform.position = Vector3.MoveTowards(LEye.transform.position, originalPosLEye, speed * Time.deltaTime);


        if (clock > 5 && clock < 6) //first trigger
            rightactive = true;

        if (clock > 20 && clock < 21)   //second trigger
        {
            rightactive = false;
            leftactive = true;
        }

        if (clock > 38 && clock < 39)   //third trigger
        {
            leftactive = false;
            rightactive = true;
        }

        if (clock > 61 && clock < 62)   //third trigger
        {
            rightactive = false;
        }

        if (clock > 68 && clock < 69)   //third trigger
        {
            leftactive = true;
        }

        if (clock > 76 && clock < 77)   //third trigger
        {
            leftactive = false;
        }

        if (clock > 81 && clock < 85)   //third trigger
        {
            rightactive = true;
        }

        if (clock > 85 && clock < 93)   //third trigger
        {
            rightactive = false;
            leftactive = true;
        }

        if (clock > 93 && clock < 100)   //third trigger
        {
            leftactive = false;
            rightactive = true;
        }
    }
}