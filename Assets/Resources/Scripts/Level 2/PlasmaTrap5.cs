using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaTrap5 : MonoBehaviour
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
            Instantiate(prebeam, new Vector2(4.17f, 0), Quaternion.Euler(0, 0, 0));
        }

        if (countdown <= 0)
        {
            readyBool = false;
            spawnPrebeam = 0;
            shoot = true;
        }

        if (shoot)
        {
            Instantiate(lightbeam, new Vector2(4.17f, 0), Quaternion.Euler(0, 0, 0));
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

        if (clock > 7 && clock < 8) //first trigger
            readyBool = true;
        if (clock > 15 && clock < 16) //second trigger
            readyBool = true;

        if (clock > 33 && clock < 34) //third trigger
            readyBool = true;
        if (clock > 37.5f && clock < 38.5f) //third trigger
            readyBool = true;

        if (clock > 45 && clock < 46) //fourth trigger
            readyBool = true;
        if (clock > 58.2 && clock < 59.2) //fourth trigger
            readyBool = true;
        if (clock > 64 && clock < 65) //fourth trigger
            readyBool = true;
        if (clock > 78 && clock < 79) //fourth trigger
            readyBool = true;
        if (clock > 84 && clock < 85) //fourth trigger
            readyBool = true;
        if (clock > 88 && clock < 89) //fourth trigger
            readyBool = true;
        if (clock > 92 && clock < 93) //fourth trigger
            readyBool = true;
        if (clock > 96 && clock < 97) //fourth trigger
            readyBool = true;

        if (clock > 101 && clock < 102) //fourth trigger
            readyBool = true;
    }
}