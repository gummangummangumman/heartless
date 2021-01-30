using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHand : MonoBehaviour
{
    private float clock;
    private float raiseSpeed = 3;
    private float resetSpeed = 1f;
    private float dropSpeed = 14;
    Vector2 originalPos;
    private Vector2 Raiseoffset;
    private Vector2 Dropoffset;
    private bool attack = false;
    private float cooldown = 2.5f;
    private bool cooldownBool = false;

    void raise()
    {
        transform.position = Vector3.MoveTowards(transform.position, originalPos + Raiseoffset, raiseSpeed * Time.deltaTime);
        cooldownBool = true;
    }

    void drop()
    {
        transform.position = Vector3.MoveTowards(transform.position, originalPos + Dropoffset, dropSpeed * Time.deltaTime);
    }

    void Start()
    {
        originalPos = transform.position;
        Raiseoffset = Vector2.up * 1.5f;
        Dropoffset = Vector2.down;
    }

    void Update()
    {
        clock += Time.deltaTime;

        if (cooldownBool)
            cooldown -= Time.deltaTime;

        if (attack)
        {
            raise();
        }

        if (cooldown <= 0)
        {
            attack = false;
            drop();
        }

        if (cooldown <= -3)
        {
            cooldownBool = false;
            cooldown = 2.5f;
        }

        if (!cooldownBool)
        {
            transform.position = Vector3.MoveTowards(transform.position, originalPos, resetSpeed * Time.deltaTime);
        }



        if (clock > 41 && clock < 42)   //First trigger
            attack = true;
        if (clock > 49.5f && clock < 50.5f)   //First trigger
            attack = true;
        if (clock > 56 && clock < 57)   //Second trigger
            attack = true;
        if (clock > 68 && clock < 69)   //Third trigger
            attack = true;
        if (clock > 78 && clock < 79)   //Third trigger
            attack = true;

        //if (clock > 84 && clock < 85)   //Fourth trigger
        //  attack = true;
        if (clock > 88 && clock < 89)   //Fifth trigger
            attack = true;
        if (clock > 95 && clock < 96)   //Sixth trigger
            attack = true;
    }
}
