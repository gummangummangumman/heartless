using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{

    private bool paused = false;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        //force unpaused mode
        paused = true;
        TogglePauseUI();
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

    public void TogglePauseUI()
    {
        if (paused)
        {
            GameObject.Find("Hero").GetComponent<HeroMovement>().enabled = true;
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
            Time.timeScale = 1;
            if(audioSource)
                audioSource.UnPause();
            paused = false;
        }
        else
        {
            GameObject.Find("Hero").GetComponent<HeroMovement>().enabled = false;
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }
            Time.timeScale = 0;
            if(audioSource)
                audioSource.Pause();
            paused = true;
        }
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
