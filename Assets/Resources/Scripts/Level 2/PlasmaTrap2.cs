using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaTrap2 : MonoBehaviour
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
            Instantiate(prebeam, new Vector2(-4.19f, 0), Quaternion.Euler(0, 0, 0));
        }

        if (countdown <= 0)
        {
            readyBool = false;
            spawnPrebeam = 0;
            shoot = true;
        }

        if (shoot)
        {
            Instantiate(lightbeam, new Vector2(-4.19f, 0), Quaternion.Euler(0, 0, 0));
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

        if (clock > 31.5f && clock < 32.5f) //third trigger
            readyBool = true;
        if (clock > 39 && clock < 40) //third trigger
            readyBool = true;

        if (clock > 51 && clock < 52) //fourth trigger
            readyBool = true;
        if (clock > 55.8 && clock < 56.8) //fourth trigger
            readyBool = true;
        if (clock > 78.3f && clock < 79.3f) //fourth trigger
            readyBool = true;
        if (clock > 82 && clock < 83) //fourth trigger
            readyBool = true;
        if (clock > 86 && clock < 87) //fourth trigger
            readyBool = true;
        if (clock > 96 && clock < 97) //fourth trigger
            readyBool = true;

        if (clock > 101 && clock < 102) //fourth trigger
            readyBool = true;
    }
}