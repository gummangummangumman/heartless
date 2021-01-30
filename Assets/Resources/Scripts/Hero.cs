using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

    public int damage;
    public Boss boss;

    private bool invincible = false;
    private bool isAttacking = false;

    private float attackTime = 1;  //time to wait between each attacks in seconds.

    void Start()
    {
        
    }

    void Update()
    {
        ListenForKeyboardInputs();
    }

    void ListenForKeyboardInputs()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !isAttacking)
        {
            StartCoroutine(Attack());
        }
    }


    private IEnumerator Attack()
    {
        isAttacking = true;

        GetComponent<Animator>().Play("Hero_attack");
        
        if (boss)
            boss.Attack(damage);

        yield return new WaitForSeconds(attackTime);

        isAttacking = false;
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
        GameObject.Find("GameOverUI").GetComponent<GameOverUI>().Show(false);
    }

    //useful for when having killed the boss
    public void MakeInvincible()
    {
        invincible = true;
    }
}
