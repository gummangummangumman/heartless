using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public Button secondLevelButton;

    void Start()
    {
        Time.timeScale = 1;
        OpenSubmenu("Main");
        if (GameObject.Find("ProgressTracker").GetComponent<ProgressTracker>().hasBeatLevel1())
            secondLevelButton.interactable = true;
    }

    public void StartLevel(int scene)
    {
        SceneManager.LoadScene(scene);
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
