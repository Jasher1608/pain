using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private KeyCode left;
    [SerializeField] private KeyCode right;
    [SerializeField] private KeyCode up;
    [SerializeField] private KeyCode down;
    [SerializeField] private KeyCode jump;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    private Vector2 velocity;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(left))
        {
            velocity = new Vector2(-1 * moveSpeed * Time.deltaTime, rb.velocity.y);
        }
        else if (Input.GetKey(right))
        {
            velocity = new Vector2(1 * moveSpeed * Time.deltaTime, rb.velocity.y);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = velocity;
    }
}
