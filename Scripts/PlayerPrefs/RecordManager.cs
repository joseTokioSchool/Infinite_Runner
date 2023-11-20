using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RecordManager : MonoBehaviour
{
    /*--------------------------------------------------- SINGLETONS --------------------------------------------------- */
    public static RecordManager Instance = null;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    /*------------------------------------------------------------------------------------------------------------------ */
    public void CheckScoreRecord(int n)
    {
        if (n > PlayerPrefs.GetInt("ScoreRecord"))
        {
            PlayerPrefs.SetInt("ScoreRecord", n);
        }
    }

    public void ResetValues()
    {
        PlayerPrefs.DeleteAll();
    }
}
