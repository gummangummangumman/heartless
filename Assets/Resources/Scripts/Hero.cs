using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

    public int damage;
    public Boss boss;

    private bool invincible = false;
    private Animator animator;

    private float attackTime = 0.5588235f;  //time to wait between each attacks in seconds.

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        ListenForKeyboardInputs();
    }

    void ListenForKeyboardInputs()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !animator.GetBool("isAttacking"))
        {
            StartCoroutine(Attack());
        }
    }


    private IEnumerator Attack()
    {
        animator.SetBool("isAttacking", true);
        
        if (boss)
            boss.Attack(damage);

        yield return new WaitForSeconds(attackTime);

        animator.SetBool("isAttacking", false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Contains("Spike") || other.name.Contains("Projectile") || other.name.Contains("LightBeam") || other.name.Contains("FistHitbox"))
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
