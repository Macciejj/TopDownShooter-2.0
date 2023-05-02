using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMover : MonoBehaviour
{
    [SerializeField] Transform player;
    NavMeshAgent meshAgent;
    // Start is called before the first frame update
    void Start()
    {
        meshAgent = GetComponent<NavMeshAgent>();
        meshAgent.SetDestination(player.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
