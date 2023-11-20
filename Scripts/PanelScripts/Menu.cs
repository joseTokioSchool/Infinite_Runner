using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ChangeScene(int n)
    {
        SceneManager.LoadScene(n);
        Time.timeScale = 1f; // Cuando usamos el "Menu pausa" para volver al "Menu principal" el tiempo esta detenido. Con esta línea de código se soluciona
    }

    public void ExitGame(int n)
    {
        Application.Quit(n);
    }
}
