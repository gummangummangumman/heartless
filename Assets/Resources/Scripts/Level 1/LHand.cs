using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHand : MonoBehaviour
{
    public GameObject fistHitbox;

    private float clock;
    private float raiseSpeed = 4;
    private float resetSpeed = 1.5f;
    private float dropSpeed = 14;
    Vector2 originalPos;
    private Vector2 Raiseoffset;
    private Vector2 Dropoffset;
    private bool attack = false;
    private float cooldown = 1.8f;
    private bool cooldownBool = false;

    void raise()
    {
        transform.position = Vector3.MoveTowards(transform.position, originalPos + Raiseoffset, raiseSpeed * Time.deltaTime);
        cooldownBool = true;
    }

    void drop()
    {
        if (transform.childCount == 0)
            Instantiate(fistHitbox, transform);
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

        if (cooldown <= -2.3f)
        {
            cooldownBool = false;
            cooldown = 1.8f;
        }

        if (!cooldownBool)
        {
            transform.position = Vector3.MoveTowards(transform.position, originalPos, resetSpeed * Time.deltaTime);
        }



        if (clock > 7 && clock < 8)   //First trigger
            attack = true;
        if (clock > 34 && clock < 35)   //First trigger
            attack = true;
        if (clock > 41 && clock < 42)   //First trigger
            attack = true;
        if (clock > 49.5f && clock < 50.5f)   //First trigger
            attack = true;
        if (clock > 56 && clock < 57)   //Second trigger
            attack = true;
        if (clock > 67 && clock < 68)   //Third trigger
            attack = true;
        if (clock > 78 && clock < 79)   //Third trigger
            attack = true;
        if (clock > 82 && clock < 83)   //Fourth trigger
            attack = true;
    }
}
