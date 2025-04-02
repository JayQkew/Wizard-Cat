using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public Vector2 moveInput;
    public Vector2 aimInput;
    [SerializeField] private bool shooting;
    [SerializeField] private bool meleeing;
    [SerializeField] private bool dashing;
    [SerializeField] private bool usingItem;

    [HideInInspector] public UnityEvent onShoot;
    [HideInInspector] public UnityEvent onShootStart;
    [HideInInspector] public UnityEvent onShootEnd;
    [HideInInspector] public UnityEvent onMelee;
    [HideInInspector] public UnityEvent onMeleeStart;
    [HideInInspector] public UnityEvent onMeleeEnd;
    [HideInInspector] public UnityEvent onDash;
    [HideInInspector] public UnityEvent onDashStart;
    [HideInInspector] public UnityEvent onDashEnd;
    [HideInInspector] public UnityEvent onItem;
    [HideInInspector] public UnityEvent onItemStart;
    [HideInInspector] public UnityEvent onItemEnd;
    [HideInInspector] public UnityEvent onInteract;

    private void Update() {
        Aim();

        if (shooting) onShoot?.Invoke();
        if (meleeing) onMelee?.Invoke();
        if (dashing) onDash?.Invoke();
        if (usingItem) onItem?.Invoke();
    }

    public void Move(InputAction.CallbackContext ctx) => moveInput = ctx.ReadValue<Vector2>();

    public void Aim() {
        if (Gamepad.current != null) {
            aimInput = Gamepad.current.leftStick.ReadValue();
        }
        else if (Mouse.current != null) {
            Vector2 mousePos = Mouse.current.position.ReadValue();
            Vector2 worldPos = Camera.main!.ScreenToWorldPoint(mousePos);
            Vector2 dir = ((Vector3)worldPos - transform.position).normalized;
            aimInput = dir;
        }
    }

    public void Shoot(InputAction.CallbackContext ctx) {
        if (ctx.performed) {
            onShootStart?.Invoke();
            shooting = true;
        }
        else if (ctx.canceled) {
            onShootEnd?.Invoke();
            shooting = false;
        }
    }

    public void Melee(InputAction.CallbackContext ctx) {
        if (ctx.performed) {
            onMeleeStart?.Invoke();
            meleeing = true;
        }
        else if (ctx.canceled) {
            onMeleeEnd?.Invoke();
            meleeing = false;
        }
    }

    public void Dash(InputAction.CallbackContext ctx) {
        if (ctx.performed) {
            onDashStart?.Invoke();
            dashing = true;
        }
        else if (ctx.canceled) {
            onDashEnd?.Invoke();
            dashing = false;
        }
    }

    public void UseItem(InputAction.CallbackContext ctx) {
        if (ctx.performed) {
            onItemStart?.Invoke();
            usingItem = true;
        }
        else if (ctx.canceled) {
            onItemEnd?.Invoke();
            usingItem = false;
        }
    }

    public void Interact(InputAction.CallbackContext ctx) {
        if (ctx.performed) onInteract?.Invoke();
    }
}