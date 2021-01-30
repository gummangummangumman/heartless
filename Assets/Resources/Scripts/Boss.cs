using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int hp;
    private bool playerIsInsideHitBox = false;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerIsInsideHitBox = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        playerIsInsideHitBox = false;
    }


    public void Attack(int damage)
    {
        if (!playerIsInsideHitBox)
            return;

        hp -= damage;
        if (hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
