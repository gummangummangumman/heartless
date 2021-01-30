using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEye : MonoBehaviour
{
    public GameObject Player;
    public GameObject Projectile;
    private float clock = 0;
    private bool canshoot = false;

    private float shootdelay = 1;


    void shoot()
    {
        Instantiate(Projectile, transform.position, transform.rotation);
        if (clock < 70)
            shootdelay = 0.85f;
        else
            shootdelay = 0.65f;
    }

    void Update()
    {
        clock += Time.deltaTime;
        shootdelay -= Time.deltaTime;

        if (Player != null)
        {
            Vector2 playerpos = Player.transform.position;

            transform.LookAt(playerpos);

            if (canshoot && shootdelay <= 0)
            {
                shoot();
            }
        }


        if (clock > 20 && clock < 29)
            canshoot = true;
        if (clock > 30 && clock < 59)
            canshoot = false;
        if (clock > 60 && clock < 80)
            canshoot = true;
    }
}
