using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour, InputActions.IInGameActionMapActions
{
    [SerializeField] Animator animator;
    [SerializeField] Camera mainCamera;
    [SerializeField] Transform cube;

    [SerializeField] RangeWeapon rangeWeapon;
    private InputActions inputActions;
    private Rigidbody rigidbody;
    private Vector3 movementDirection;
    private Vector3 movement;
    private bool isShooting = false;

    [field: SerializeField] public float MovementSpeed { get; protected set; }
    [field: SerializeField] public float RotationSpeed { get; protected set; }


    
    private void OnEnable()
    {
        inputActions = new InputActions();
        inputActions.InGameActionMap.SetCallbacks(this);
        inputActions.InGameActionMap.Enable();
    }
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void OnDisable()
    {
        inputActions.InGameActionMap.Disable();
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = movement;
        
        animator.SetFloat("movement Speed", movement.magnitude);
        if (isShooting) rangeWeapon.Attack(animator);
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

    public void OnShot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            isShooting = true;
        }
        if (context.canceled)
        {
            isShooting = false;
        }
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        Vector2 inputMousePos = context.ReadValue<Vector2>();
        Vector3 mouseWorldPos = mainCamera.ScreenToWorldPoint(new Vector3(inputMousePos.x, inputMousePos.y, Vector3.Distance(mainCamera.transform.position, transform.position)));
        Vector3 rotationDirection = new Vector3(mouseWorldPos.x, transform.position.y, mouseWorldPos.z) - transform.position;
        cube.position = rotationDirection;
        Debug.Log(rotationDirection);

        rotationDirection.Normalize();
        transform.forward = Vector3.Lerp(transform.forward, rotationDirection, Time.deltaTime * RotationSpeed);
    }
}
