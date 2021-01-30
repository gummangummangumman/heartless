using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAnimation1 : MonoBehaviour
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

        if(customTimerBool1 == false && customTimerBool2 == false)
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

        if (clock > 10 && clock < 11)   //first trigger
            lowerBool = true;

        if (clock > 18 && clock < 19)   //second trigger
            lowerBool = true;

        if (clock > 26 && clock < 27)   //third trigger (need customtimer1)
        {
            customTimerBool1 = true;
            lowerBool = true;
        }

        if (clock > 54 && clock < 55)   //fourth trigger
            lowerBool = true;

        if (clock > 65 && clock < 66)   //fith trigger (need customtimer2)
        {
            customTimerBool2 = true;
            lowerBool = true;
        }

        if (clock > 90 && clock < 91)   //sixth trigger
            lowerBool = true;

        if (clock > 96 && clock < 97)   //fourth trigger
            lowerBool = true;
    }
}