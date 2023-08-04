using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private Vector2 velocity;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get the horizontal input (left and right arrow keys, A and D keys, or joystick)
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // Calculate the velocity vector
        velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        // Apply the velocity to the Rigidbody
        rb.velocity = velocity;
    }

    private void FixedUpdate()
    {
        rb.velocity = velocity;
    }
}
