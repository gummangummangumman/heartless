using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightEye : MonoBehaviour
{
    public Hero hero;
    public GameUI gameUI;
    public Level2Boss boss;
    public GameOverUI gameOverUI;

    private bool playerIsInsideHitBox = false;

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
        boss.hp -= damage;
    }
}