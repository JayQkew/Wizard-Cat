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
    [SerializeField] private bool shooting;
    [SerializeField] private bool meleeing;
    [SerializeField] private bool dashing;

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

    private void Update()
    {
        if (shooting) onShoot?.Invoke();
        if (meleeing) onMelee?.Invoke();
        if (dashing) onDash?.Invoke();
    }

    public void Move(InputAction.CallbackContext ctx) => moveInput = ctx.ReadValue<Vector2>();

    public void Aim(InputAction.CallbackContext ctx) => aimInput = ctx.ReadValue<Vector2>();

    public void Shoot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            onShootStart?.Invoke();
            shooting = true;
        }
        else if (ctx.canceled)
        {
            onShootEnd?.Invoke();
            shooting = false;
        }
    }

    public void Melee(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            onMeleeStart?.Invoke();
            meleeing = true;
        }
        else if (ctx.canceled)
        {
            onMeleeEnd?.Invoke();
            meleeing = false;
        }
    }

    public void Dash(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            onDashStart?.Invoke();
            dashing = true;
        }
        else if (ctx.canceled)
        {
            onDashEnd?.Invoke();
            dashing = false;
        }
    }

    public void Interact(InputAction.CallbackContext ctx)
    {
        if(ctx.performed) onInteract?.Invoke();
    }
}