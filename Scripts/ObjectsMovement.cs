using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{
    [SerializeField] private float speed; // Iniciar en -12 para el PIN y en -10 para el OBSTACLE.
    public Rigidbody rb;
    void FixedUpdate()
    {
        Vector3 backMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + backMove);
    }
}
