using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    private float speed = 8f;
    private float clock = 5;
    public GameObject projectile;

    void Start()
    {
        transform.Translate(Vector3.forward);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        clock -= Time.deltaTime;

        if (clock <= 0)
            Destroy(projectile);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kill player
    }
}
