using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaTrap6 : MonoBehaviour
{
    private float clock = -1.5f;
    public GameObject lightbeam;
    public GameObject prebeam;
    private float countdown = 1.7f;
    private float delay = 1.7f;
    private bool readyBool = false;
    private bool shoot = false;
    private bool hide = false;
    private int spawnPrebeam = 0;


    void Update()
    {
        clock += Time.deltaTime;

        if (readyBool)
        {
            spawnPrebeam++;
            // transform.position = Vector3.MoveTowards(transform.position, originalPos + offset, speed * Time.deltaTime); 
            countdown -= Time.deltaTime;
        }

        if (spawnPrebeam == 1)
        {
            Instantiate(prebeam, new Vector2(6.76f, 0), Quaternion.Euler(0, 0, 0));
        }

        if (countdown <= 0)
        {
            readyBool = false;
            spawnPrebeam = 0;
            shoot = true;
        }

        if (shoot)
        {
            Instantiate(lightbeam, new Vector2(6.76f, 0), Quaternion.Euler(0, 0, 0));
            countdown = 1.7f;
            hide = true;
        }

        if (hide)
        {
            shoot = false;
            // transform.position = Vector3.MoveTowards(transform.position, originalPos, speed * Time.deltaTime);
            delay -= Time.deltaTime;
        }

        if (delay <= 0)
        {
            hide = false;
            delay = 1.7f;
        }

        if (clock > 5 && clock < 6) //first trigger
            readyBool = true;
        if (clock > 17 && clock < 18) //second trigger
            readyBool = true;

        if (clock > 32.5f && clock < 33.5f) //third trigger
            readyBool = true;
        if (clock > 38 && clock < 39) //third trigger
            readyBool = true;

        if (clock > 43 && clock < 44) //third trigger
            readyBool = true;
        if (clock > 64 && clock < 65) //fourth trigger
            readyBool = true;
        if (clock > 78 && clock < 79) //fourth trigger
            readyBool = true;
        if (clock > 90 && clock < 91) //fourth trigger
            readyBool = true;
        if (clock > 94 && clock < 95) //fourth trigger
            readyBool = true;
        if (clock > 98 && clock < 99) //fourth trigger
            readyBool = true;

        if (clock > 101 && clock < 102) //fourth trigger
            readyBool = true;
    }
}