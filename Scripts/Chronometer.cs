using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Chronometer : MonoBehaviour 
{
    [SerializeField] TMP_Text chronoText;
    public float chronometer;

    void Start()
    {
        chronometer = 0;  
    }
    void Update()
    {
        if (!GameManager.Instance.gameOver)
        {
            chronometer += Time.deltaTime;
            chronoText.text = chronometer.ToString("F0");
        }
    }
}
