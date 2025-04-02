using System;
using UnityEngine;

public class Aim : MonoBehaviour
{
    private InputHandler _inputHandler;

    [Header("Testing")]
    [SerializeField] private GameObject aimObject;

    [SerializeField] private float aimDistance = 1.5f;

    private void Awake() {
        _inputHandler = GetComponent<InputHandler>();
    }

    private void Update() {
        aimObject.transform.localPosition = _inputHandler.aimInput * aimDistance;
    }
}