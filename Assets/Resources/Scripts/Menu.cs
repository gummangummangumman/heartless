using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    void Start()
    {
        
    }

    public void StartGame()
    {
        print("start the game!");
    }

    public void ExitGame()
    {
        print("Exit the game!");
    }

    public void OpenSubmenu(string submenu)
    {
        foreach (Transform child in transform)
        {
            if (child.name == submenu)
                child.gameObject.SetActive(true);
            else
                child.gameObject.SetActive(false);
        }
    }
}
