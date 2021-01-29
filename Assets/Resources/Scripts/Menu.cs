using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        OpenSubmenu("Main");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        print("You exited the game!");
        Application.Quit();
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
