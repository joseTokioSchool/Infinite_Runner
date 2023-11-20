using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /*--------------------------------------------------- SINGLETONS --------------------------------------------------- */
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }
    /*------------------------------------------------------------------------------------------------------------------ */

    /*---------------------------------- VARIABLES ----------------------------------*/
    [SerializeField] public TMP_Text playerScoreText;
    public int playerScored;
    public bool gameOver = false;
    /*---------------------------------- Para aumentar la puntuación del jugador.----------------------------------*/
    public void PlayerScored()
    {
        playerScored++;
        playerScoreText.text = playerScored.ToString();
        RecordManager.Instance.CheckScoreRecord(playerScored);
        Debug.Log("El record es: " + PlayerPrefs.GetInt("ScoreRecord"));
    }

    /*---------------------------------- Para acabar la partida.----------------------------------*/
    public void GameOver()
    {
        gameOver = true;
        Time.timeScale = 0f;
    }

    /*---------------------------------- Para reiniciar la partida.----------------------------------*/
    public void RestartGame()
    {
        playerScored = 0;
        playerScoreText.text = playerScored.ToString();
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /*---------------------------------- Para ir al Menú Principal.----------------------------------*/
    public void MainMenu(int n)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(n);
    }
}
