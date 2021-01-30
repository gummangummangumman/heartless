using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaTrap3 : MonoBehaviour
{
    private float clock = 0;
    private float speed = 6;
    public GameObject lightbeam;
    Vector2 originalPos;
    private Vector2 offset;
    private float countdown = 1.7f;
    private float delay = 1.7f;
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
        offset = Vector2.up * 0.8f;
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
            Instantiate(lightbeam, new Vector2(-1.47f, 0), Quaternion.Euler(0, 0, 0));
            countdown = 1.7f;
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
            delay = 1.7f;
        }

        if (clock > 9 && clock < 10) //first trigger
            readyBool = true;
        if (clock > 13 && clock < 14) //second trigger
            readyBool = true;
        if (clock > 34 && clock < 35) //third trigger
            readyBool = true;
        if (clock > 49 && clock < 50) //fourth trigger
            readyBool = true;
        if (clock > 56.6 && clock < 57.6) //fourth trigger
            readyBool = true;
        if (clock > 88 && clock < 89) //fifth trigger
            readyBool = true;
        if (clock > 92 && clock < 93) //sixth trigger
            readyBool = true;
    }
}