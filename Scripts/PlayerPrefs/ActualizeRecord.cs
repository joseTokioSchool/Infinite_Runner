using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActualizeRecord : MonoBehaviour
{
    public TextMeshProUGUI recordText;
    void Start()
    {
        recordText.text = "Record: " + PlayerPrefs.GetInt("ScoreRecord").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
