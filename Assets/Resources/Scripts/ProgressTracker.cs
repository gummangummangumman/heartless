using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressTracker : MonoBehaviour
{
    //singleton
    private static ProgressTracker instance;
    public ProgressTracker Instance { get { return instance; } }

    private string beatLevel1Key = "beatLevel1";
    private bool beatLevel1 = false;
    private float volume = 0.5f;

    public Slider slider;

    private void Awake()
    {

        if(instance != null  && instance != this)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
        }

         DontDestroyOnLoad(gameObject);



        if (PlayerPrefs.GetString(beatLevel1Key) == "true")
            beatLevel1 = true;

        if (PlayerPrefs.HasKey("volume"))
            volume = PlayerPrefs.GetFloat("volume");
    }

    public void BeatLevel1()
    {
        beatLevel1 = true;
        PlayerPrefs.SetString(beatLevel1Key, "true");
        PlayerPrefs.Save();
    }

    public bool HasBeatLevel1()
    {
        return beatLevel1;
    }

    public void SetVolume(float volume)
    {
        this.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.Save();
    }

    public float GetVolume()
    {
        return volume;
    }
}
