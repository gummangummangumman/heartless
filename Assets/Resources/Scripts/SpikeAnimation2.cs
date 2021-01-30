using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAnimation2 : MonoBehaviour
{
    private float speedSlow = 1;
    private float speedFast = 9;
    Vector2 originalPosition;
    private float clock = 0;
    public Vector2 lowerOffset;
    public Vector2 dropOffset;
    private float dropTimer = 2;
    public bool dropTimerBool = false;
    private float resetTimer = 3;

    void fall()
    {
        transform.position = Vector3.MoveTowards(transform.position, originalPosition + dropOffset, speedFast * Time.deltaTime);
        resetTimer -= Time.deltaTime;

        if(resetTimer <= 0)
        {
            transform.position = originalPosition;
            dropTimerBool = false;
            dropTimer = 2;
            resetTimer = 3;
        }
    }

    void lower()
    {
        transform.position = Vector3.MoveTowards(transform.position, originalPosition + lowerOffset, speedSlow * Time.deltaTime);
        dropTimerBool = true;
    }

    private void Start()
    {
        originalPosition = transform.position;
        lowerOffset = Vector2.down * 0.4f;
        dropOffset = Vector2.down * 14;
    }

    void Update()
    {
        if (dropTimerBool)
            dropTimer -= Time.deltaTime;

        if(dropTimer <= 0)
        {
            fall();
        }

        clock += Time.deltaTime;

        if (clock > 10 && clock < 11)
        {
            lower();
        }
    }
}