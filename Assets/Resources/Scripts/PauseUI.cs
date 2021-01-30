using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUI : MonoBehaviour
{

    private bool paused = false;

    void Start()
    {
        
    }
    
    void Update()
    {
        ListenForKeyboardInputs();
    }

    void ListenForKeyboardInputs()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseUI();
        }
    }

    void TogglePauseUI()
    {
        if (paused)
        {
            //TODO toggle EventSystem ellerno... ikke tillat at knappetrykk gir effekt
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
            Time.timeScale = 1;
            paused = false;
        }
        else
        {
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }
            Time.timeScale = 0;
            paused = true;
        }
    }
}
