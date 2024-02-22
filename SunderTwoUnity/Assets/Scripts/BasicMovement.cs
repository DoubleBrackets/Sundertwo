using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasicMovement : MonoBehaviour
{
    [SerializeField]
    private InputAction movementInput;
    
    [SerializeField]
    private float speed;

    private void Awake()
    {
        movementInput.Enable();
    }

    void Update()
    {
        Vector2 input = movementInput.ReadValue<Vector2>();
        transform.position += new Vector3(input.x, input.y, 0) * (speed * Time.deltaTime);
    }
}
