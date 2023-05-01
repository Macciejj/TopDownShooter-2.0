using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour, InputActions.IInGameActionMapActions
{
    [SerializeField] Animator animator;
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

    private void FixedUpdate()
    {
        transform.position += movement;
        transform.forward = Vector3.Lerp(transform.forward, movementDirection, Time.deltaTime * RotationSpeed);
        animator.SetFloat("movement Speed", movement.magnitude);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 inputMovement = context.ReadValue<Vector2>();
        movement = Vector3.zero;
        if (inputMovement == Vector2.zero)
        {         
            return;
        } 
        movementDirection = new Vector3(inputMovement.x, 0, inputMovement.y);
        movementDirection.Normalize();
        movement = MovementSpeed* movementDirection;
        
    }
}
