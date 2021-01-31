using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Boss : MonoBehaviour
{
    public int hp;
    public Hero hero;
    public RightEye rightEye;
    public LeftEye leftEye;
    public GameUI gameUI;
    public GameOverUI gameOverUI;

    void Start()
    {

    }

    void Update()
    {
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