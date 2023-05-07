using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class AIMover : MonoBehaviour
{
    [SerializeField] float seeingRange = 5;
    [SerializeField] float shootingRange = 4;
    [SerializeField] float stoppingDistance = 1;
    [SerializeField] Weapon weapon;
    [SerializeField] Animator animator;
    [SerializeField] Transform playerTranform;
    [SerializeField] LayerMask layerMask;
    [SerializeField] float rotationSpeed;
    NavMeshAgent navMesh;
    bool haveSeenPlayer = false;
    RaycastHit[] walls;


    private void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        walls = Physics.RaycastAll(transform.position, GetDirectionToPlayer(), GetDistanceToPlayer(), layerMask);
        Debug.DrawRay(transform.position, GetDirectionToPlayer() * GetDistanceToPlayer(), Color.red);

        if (!haveSeenPlayer)
        {
            haveSeenPlayer = !walls.Any() && GetDistanceToPlayer() < seeingRange;
            return;
        }

        if (GetDistanceToPlayer() < shootingRange)
        {
            if (!walls.Any())
            {
                navMesh.SetDestination(playerTranform.position);
                weapon.Attack(animator);
            }
        }
        animator.SetFloat("movement Speed", navMesh.velocity.magnitude);
        //if()
    }

    private void LateUpdate()
    {
        if (haveSeenPlayer)
        {
            Vector3 movementDirection = playerTranform.position - transform.position;
            transform.forward = Vector3.Lerp(transform.forward, movementDirection, Time.deltaTime * rotationSpeed);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, seeingRange);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, shootingRange);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, stoppingDistance);

    }


    private float GetDistanceToPlayer()
    {
        return Vector3.Distance(transform.position, playerTranform.position);
    }

    private Vector3 GetDirectionToPlayer()
    {
        Vector3 direction = playerTranform.position - transform.position;
        direction.Normalize();
        return direction;
    }


}
