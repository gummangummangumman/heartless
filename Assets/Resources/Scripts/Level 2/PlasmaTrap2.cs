using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaTrap2 : MonoBehaviour
{
    private float clock = 0;
    private float speed = 4;
    public GameObject lightbeam;
    Vector2 originalPos;
    private Vector2 offset;
    private float countdown = 2;
    private float delay = 2;
    private bool readyBool = false;
    private bool shoot = false;
    private bool hide = false;

    /*void shoot()
    {
        Instantiate(lightbeam, new Vector2(-6.46f, 0), Quaternion.Euler(0, 0, 0));
        delay -= Time.deltaTime;
    }*/

   
    void Start()
    {
        originalPos = transform.position;
        offset = Vector2.up * 0.3f;
    }

    void Update()
    {
        clock += Time.deltaTime;

        if (readyBool)
        {
            transform.position = Vector3.MoveTowards(transform.position, originalPos + offset, speed * Time.deltaTime);
            countdown -= Time.deltaTime;
        }

        if (countdown <= 0)
        {
            readyBool = false;
            shoot = true;
        }

        if (shoot)
        {
            Instantiate(lightbeam, new Vector2(-4.02f, 0), Quaternion.Euler(0, 0, 0));
            countdown = 2;
            hide = true;
        }

        if (hide)
        {
            shoot = false;
            transform.position = Vector3.MoveTowards(transform.position, originalPos, speed * Time.deltaTime);
            delay -= Time.deltaTime;
        }

        if (delay <= 0)
        {
            hide = false;
            delay = 2;
        }

        if (clock > 7 && clock < 8) //first trigger
            readyBool = true;
        if (clock > 15 && clock < 16) //second trigger
            readyBool = true;
        if (clock > 32.5f && clock < 33.5f) //third trigger
            readyBool = true;
        if (clock > 55 && clock < 56) //fourth trigger
            readyBool = true;
        if (clock > 84 && clock < 85) //fifth trigger
            readyBool = true;
        if (clock > 96 && clock < 97) //sixth trigger
            readyBool = true;
    }
}