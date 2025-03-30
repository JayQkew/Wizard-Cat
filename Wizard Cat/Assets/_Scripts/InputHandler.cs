using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public static InputHandler Instance { get; private set; }
    private PlayerInput playerInput;

    public Vector2 moveInput;
    public Vector2 aimInput;

    [HideInInspector] public UnityEvent onShoot;
    [HideInInspector] public UnityEvent onShootStart;
    [HideInInspector] public UnityEvent onShootEnd;
    [HideInInspector] public UnityEvent onMelee;
    [HideInInspector] public UnityEvent onMeleeStart;
    [HideInInspector] public UnityEvent onMeleeEnd;
    [HideInInspector] public UnityEvent onDash;
    [HideInInspector] public UnityEvent onDashStart;
    [HideInInspector] public UnityEvent onDashEnd;
    [HideInInspector] public UnityEvent onInteract;
    
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);
        
        playerInput = GetComponent<PlayerInput>();
    }
}
