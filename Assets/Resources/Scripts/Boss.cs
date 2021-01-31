using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int hp;
    public Hero hero;
    public GameUI gameUI;
    public GameOverUI gameOverUI;

    private float invincibleTime = 9.3f;//time in seconds boss is invincible at the beginning of the level

    private bool isInvincible = true;
    private bool playerIsInsideHitBox = false;

    void Start()
    {
        StartCoroutine(makeVulnerable());
        gameUI.gameObject.SetActive(false);
    }
    
    void Update()
    {
        
    }

    private IEnumerator makeVulnerable()
    {
        yield return new WaitForSeconds(invincibleTime);
        gameUI.gameObject.SetActive(true);
        isInvincible = false;
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
        if (!playerIsInsideHitBox || isInvincible)
            return;

        hp -= damage;
        gameUI.updateHP(hp);
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