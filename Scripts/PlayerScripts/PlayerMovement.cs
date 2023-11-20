using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed; // 7
    float movement;
    private float xBound = 3.65f; // Variable para delimitar el eje X donde puede llegar el player.

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vector2 horizontalMove = transform.position;
        horizontalMove.x = Mathf.Clamp(horizontalMove.x + movement * speed * Time.deltaTime, -xBound, xBound);
        transform.position = horizontalMove;
        movement = Input.GetAxisRaw("Horizontal");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GameOver");
            GameManager.Instance.GameOver();
        }
        if (other.gameObject.CompareTag("Pin"))
        {
            Debug.Log("+1 punto");
            GameManager.Instance.PlayerScored();
            other.gameObject.SetActive(false);
        }

    }
}
