using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour, InputActions.IInGameActionMapActions
{
    private InputActions inputActions;
    private Vector3 movementDirection;
    private Vector3 movement;
    [field: SerializeField] public float MovementSpeed { get; protected set; }
    [field: SerializeField] public float RotationSpeed { get; protected set; }
    private void OnEnable()
    {
        inputActions = new InputActions();
        inputActions.InGameActionMap.SetCallbacks(this);
        inputActions.InGameActionMap.Enable();
    }

    private void OnDisable()
    {
        inputActions.InGameActionMap.Disable();
    }

    private void Update()
    {
        transform.position += movement;
        transform.forward = Vector3.Lerp(transform.forward, movementDirection, Time.deltaTime * RotationSpeed);
    }

    public void OnMove(InputAction.CallbackContext context)
    { 
        movement = Vector3.zero;
        if(context.ReadValue<Vector2>() == Vector2.zero) return;
        movementDirection = new Vector3(context.ReadValue<Vector2>().x, 0, context.ReadValue<Vector2>().y);
        movementDirection.Normalize();
        movement = MovementSpeed* movementDirection;
    }
}
