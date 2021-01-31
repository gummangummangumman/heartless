using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text text;

    public void updateHP(int hp)
    {
        if (hp < 0)
            hp = 0;
        text.text = hp.ToString();
    }
}