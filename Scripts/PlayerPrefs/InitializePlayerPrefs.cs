using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePlayerPrefs : MonoBehaviour
{
    void Awake()
    {
        if (!PlayerPrefs.HasKey("ScoreRecord"))
        {
            PlayerPrefs.SetInt("ScoreRecord", 0);
        }
    }
}
