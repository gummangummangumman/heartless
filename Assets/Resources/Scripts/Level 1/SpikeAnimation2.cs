using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAnimation2 : MonoBehaviour
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
    private float customTimer3 = 4;
    private bool customTimerBool3 = false;
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

        if (customTimerBool1 == false && customTimerBool2 == false && customTimerBool3 == false && customTimerBool4 == false)
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

        if (dropTimer <= 0)
        {
            lowerBool = false;
            fall();
        }

        clock += Time.deltaTime;

        if (clock > 11.5f && clock < 12.5f)   //second trigger
            lowerBool = true;

          if (clock > 23 && clock < 24)   //third trigger (need customtimer1)
          {
              customTimerBool1 = true;
              lowerBool = true;
          } 

        if (clock > 27 && clock < 28)   //first trigger
        {
          //  customTimerBool4 = true;
            lowerBool = true;
        }

        if (clock > 54 && clock < 55)   //second trigger
            lowerBool = true;

        if (clock > 65.3 && clock < 66.3)   //third trigger
        {
            customTimerBool2 = true;
            lowerBool = true;
        }

        if (clock > 78 && clock < 79)   //fourth trigger
        {
            customTimerBool3 = true;
            lowerBool = true;
        }

        if (clock > 86 && clock < 87)   //fithx trigger
            lowerBool = true;

        if (clock > 96 && clock < 97)   //fourth trigger
            lowerBool = true;
    }
}