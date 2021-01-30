using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
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
        print("rawr");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print("collided with " + other.name);
        if (other.name.Contains("Spike"))
            Die();
    }

    void Die()
    {
        print("game over");
        Destroy(gameObject); //TODO animate death somehow
        Time.timeScale = 0.2f;
        GameObject.Find("DeathUI").GetComponent<DeathUI>().Show();
    }
}
