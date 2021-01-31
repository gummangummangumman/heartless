using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAnimation1 : MonoBehaviour
{
    private float speedSlow = 2;
    private float speedFast = 18;
    Vector2 originalPosition;
    private float clock = 0;
    public Vector2 lowerOffset;
    public Vector2 dropOffset;
    private float dropTimer = 1.1f;
    public bool dropTimerBool = false;
    private float resetTimer = 1f;
    private bool lowerBool = false;

    private float customTimer1 = 2;
    private bool customTimerBool1 = false;
    private float customTimer2 = 4;
    private bool customTimerBool2 = false;
    private float customTimer4 = 3;
    private bool customTimerBool4 = false;

    void fall()
    {
        transform.position = Vector3.MoveTowards(transform.position, originalPosition + dropOffset, speedFast * Time.deltaTime);
        resetTimer -= Time.deltaTime;

        if (resetTimer <= 0)
        {
            transform.position = originalPosition;
            dropTimerBool = false;
            dropTimer = 1.1f;
            resetTimer = 1f;
        }
    }

    void lower()
    {
        transform.position = Vector3.MoveTowards(transform.position, originalPosition + lowerOffset, speedSlow * Time.deltaTime);

        if(customTimerBool1 == false && customTimerBool2 == false && customTimerBool4 == false)
            dropTimerBool = true;
        else if(customTimerBool1 == true)
        {
            customTimer1 -= Time.deltaTime;
            if(customTimer1 < 0)
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
        else if (customTimerBool4 == true)
        {
            customTimer4 -= Time.deltaTime;
            if (customTimer4 < 0)
            {
                dropTimerBool = true;
                customTimerBool4 = false;
            }
        }
    }

    private void Start()
    {
        originalPosition = transform.position;
        lowerOffset = Vector2.down * 0.7f;
        dropOffset = Vector2.down * 14;
    }

    void Update()
    {
        if (lowerBool)
            lower();

        if (dropTimerBool)
            dropTimer -= Time.deltaTime;

        if(dropTimer <= 0)
        {
            lowerBool = false;
            fall();
        }

        clock += Time.deltaTime;

        if (clock > 7.5f && clock < 8.5f)   //first trigger
            lowerBool = true;

        if (clock > 15.5f && clock < 16.5f)   //second trigger
            lowerBool = true;

         if (clock > 22 && clock < 23)   //third trigger (need customtimer1)
        {
            customTimerBool1 = true;
            lowerBool = true;
        } 

        if (clock > 28 && clock < 29)   //first trigger
        {
            lowerBool = true;
        }

        if (clock > 35 && clock < 36)   //first trigger
        {
            lowerBool = true;
        }

        if (clock > 40 && clock < 41)   //second trigger
            lowerBool = true;

        if (clock > 54 && clock < 55)   //fourth trigger
            lowerBool = true;

        if (clock > 64 && clock < 65)   //fith trigger (need customtimer2)
        {
            customTimerBool2 = true;
            lowerBool = true;
        }

        if (clock > 83 && clock < 84)   //sixth trigger
            lowerBool = true;

    }
}