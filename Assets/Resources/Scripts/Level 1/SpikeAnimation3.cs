using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAnimation3 : MonoBehaviour
{
    private float speedSlow = 1;
    private float speedFast = 11;
    Vector2 originalPosition;
    private float clock = 0;
    public Vector2 lowerOffset;
    public Vector2 dropOffset;
    private float dropTimer = 1.8f;
    public bool dropTimerBool = false;
    private float resetTimer = 1.4f;
    private bool lowerBool = false;

    private float customTimer1 = 4;
    private bool customTimerBool1 = false;
    private float customTimer2 = 4;
    private bool customTimerBool2 = false;
    private float customTimer3 = 4;
    private bool customTimerBool3 = false;


    void fall()
    {
        transform.position = Vector3.MoveTowards(transform.position, originalPosition + dropOffset, speedFast * Time.deltaTime);
        resetTimer -= Time.deltaTime;

        if (resetTimer <= 0)
        {
            transform.position = originalPosition;
            dropTimerBool = false;
            dropTimer = 1.8f;
            resetTimer = 1.4f;
        }
    }

    void lower()
    {
        transform.position = Vector3.MoveTowards(transform.position, originalPosition + lowerOffset, speedSlow * Time.deltaTime);

        if (customTimerBool1 == false && customTimerBool2 == false && customTimerBool3 == false)
            dropTimerBool = true;
        else if (customTimerBool1 == true)
        {
            customTimer1 -= Time.deltaTime;
            if (customTimer1 < 0)
            {
                dropTimerBool = true;
                customTimerBool1 = false;
            }
        }
        else if (customTimerBool2 == true)
        {
            customTimer2 -= Time.deltaTime;
            if (customTimer2 < 0)
            {
                dropTimerBool = true;
                customTimerBool2 = false;
            }
        }
        else if (customTimerBool3 == true)
        {
            customTimer3 -= Time.deltaTime;
            if (customTimer3 < 0)
            {
                dropTimerBool = true;
                customTimerBool3 = false;
            }
        }
    }

    private void Start()
    {
        originalPosition = transform.position;
        lowerOffset = Vector2.down * 0.4f;
        dropOffset = Vector2.down * 14;
    }

    void Update()
    {
        if (lowerBool)
            lower();

        if (dropTimerBool)
            dropTimer -= Time.deltaTime;

        if (dropTimer <= 0)
        {
            lowerBool = false;
            fall();
        }

        clock += Time.deltaTime;

        if (clock > 30 && clock < 31)   //first trigger
        {
            customTimerBool1 = true;
            lowerBool = true;
        }

        if (clock > 50 && clock < 51) //second trigger
            lowerBool = true;

        if (clock > 54 && clock < 55) //third trigger
            lowerBool = true;

        if (clock > 67 && clock < 68)   //fourth trigger
        {
            customTimerBool2 = true;
            lowerBool = true;
        }

        if (clock > 77 && clock < 78)   //fifth trigger
        {
            customTimerBool3 = true;
            lowerBool = true;
        }

        if (clock > 84 && clock < 85) //sixth trigger
            lowerBool = true;

        if (clock > 96 && clock < 97)   //fourth trigger
            lowerBool = true;
    }
}