using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] PauseGame pauseGame;
    [SerializeField] private float rotateSpeed; // 1.5
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        if (!GameManager.Instance.gameOver && !pauseGame.isPaused) //Para detener la rotación del jugador cuando el juego acabe y este en pausa.
        {
            transform.Rotate(Vector3.right * rotateSpeed, Space.World);
        }
    }
}
