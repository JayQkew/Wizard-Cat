using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Rigidbody2D _rb;
    private InputHandler _inputHandler;

    private void Awake()
    {
        _inputHandler = GetComponent<InputHandler>();
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0;
    }

    private void Update()
    {
        Move(_inputHandler.moveInput);
    }

    private void Move(Vector2 dir)
    {
        _rb.linearVelocity = dir * moveSpeed;
    }
}
