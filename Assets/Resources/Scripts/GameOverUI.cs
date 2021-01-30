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
        SceneManager.LoadScene(0);
    }
}
