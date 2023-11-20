using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGame : MonoBehaviour
{
    [SerializeField] GameObject endGamePanel;
    void Start()
    {
        endGamePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.gameOver)
        {
            endGamePanel.SetActive(true);
        }

    }
}
