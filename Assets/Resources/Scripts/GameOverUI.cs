using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameOverUI : MonoBehaviour
{

    public Text text;

    void Start()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    public void Show(bool success)
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }

        if (success)
        {
            text.text = "Success!";
        }
        else
        {
            text.text = "Game over";
        }
    }

    public void QuitToMainMenu()
    {
        if (text.text == "Game over")
        {
            SceneManager.LoadScene(0);
            return;
        }

        switch (SceneManager.GetActiveScene().buildIndex)
        {
            case 1:
                SceneManager.LoadScene(3);
                break;

            case 2:
                SceneManager.LoadScene(4);
                break;

            default:
                SceneManager.LoadScene(0);
                break;
        }        
    }
}
