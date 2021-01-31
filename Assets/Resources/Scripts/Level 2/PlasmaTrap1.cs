using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaTrap1 : MonoBehaviour
{
    private float clock = 0;
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
            Instantiate(prebeam, new Vector2(-6.88f, 0), Quaternion.Euler(0, 0, 0));
        }

        if (countdown <= 0)
        {
            readyBool = false;
            spawnPrebeam = 0;
            shoot = true;
        }

        if (shoot)
        {
            Instantiate(lightbeam, new Vector2(-6.88f, 0), Quaternion.Euler(0, 0, 0));
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

        if (clock > 32 && clock < 33) //third trigger
            readyBool = true;
        if (clock > 38.5f && clock < 39.5f) //third trigger
            readyBool = true;

        if (clock > 53 && clock < 54) //fourth trigger
            readyBool = true;
        if (clock > 55 && clock < 56) //fourth trigger
            readyBool = true;
        if (clock > 64 && clock < 65) //fourth trigger
            readyBool = true;
        if (clock > 78 && clock < 79) //fourth trigger
            readyBool = true;
        /*   if (clock > 80 && clock < 81) //fifth trigger
               readyBool = true;
           if (clock > 100 && clock < 101) //sixth trigger
               readyBool = true;*/
    }
}