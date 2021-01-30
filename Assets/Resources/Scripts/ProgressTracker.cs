using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressTracker : MonoBehaviour
{

    private string beatLevel1Key = "beatLevel1";
    private bool beatLevel1 = false;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (PlayerPrefs.GetString(beatLevel1Key) == "true")
            beatLevel1 = true;
    }

    public void BeatLevel1()
    {
        beatLevel1 = true;
        PlayerPrefs.SetString(beatLevel1Key, "true");
        PlayerPrefs.Save();
    }

    public bool hasBeatLevel1()
    {
        return beatLevel1;
    }
}
