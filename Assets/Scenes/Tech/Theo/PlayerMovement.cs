using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]

// Theo Kaminsky, Theo#6969
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerStatsScriptable _playerStatsScriptable;
    
    private Rigidbody _rigidbody;
    private Vector3 _velocity;
    private Camera _camera;
    private Vector3 _forward;
    private Vector3 _right;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _camera = Camera.main;
        _forward = _camera.transform.forward;
        _right = _camera.transform.right;

        _forward.y = 0f;
        _right.y = 0f;

        _forward.Normalize();
        _right.Normalize();
    }

    private void Update()
    {
        _rigidbody.velocity = _velocity * _playerStatsScriptable.movementSpeed;
    }

    public void HandeMovementInput(InputAction.CallbackContext context)
    {
        // moving direction is calculated relative to the camera
        Vector3 inputVector = context.ReadValue<Vector2>().x * _right + 
                              context.ReadValue<Vector2>().y * _forward;
        _velocity = inputVector;
    }
}
