using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int hp;
    public Hero hero;
    public GameOverUI gameOverUI;

    private bool playerIsInsideHitBox = false;

    

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerIsInsideHitBox = true;
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerIsInsideHitBox = false;
    }


    public void Attack(int damage)
    {
        if (!playerIsInsideHitBox)
            return;

        hp -= damage;
        print("hp left: " + hp);
        if (hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Time.timeScale = 0.2f;
        hero.MakeInvincible();
        GameObject.Find("ProgressTracker").GetComponent<ProgressTracker>().BeatLevel1();
        gameOverUI.Show(true);
        Destroy(gameObject);
    }
}
