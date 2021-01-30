using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

    public int damage;
    public Boss boss;

    private bool invincible = false;

    void Start()
    {
        
    }

    void Update()
    {
        ListenForKeyboardInputs();
    }

    void ListenForKeyboardInputs()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }


    void Attack()
    {
        if(boss)
            boss.Attack(damage);
        //TODO cooldown
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Spike"))
            Die();
    }

    void Die()
    {
        if (invincible)
            return;

        print("game over");
        Destroy(gameObject); //TODO animate death somehow
        Time.timeScale = 0.2f;
        GameObject.Find("DeathUI").GetComponent<DeathUI>().Show();
    }

    //useful for when having killed the boss
    public void MakeInvincible()
    {
        invincible = true;
    }
}
