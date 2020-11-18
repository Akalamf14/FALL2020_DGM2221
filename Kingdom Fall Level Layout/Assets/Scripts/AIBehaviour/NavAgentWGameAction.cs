using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentWGameAction : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform destination;
    public GameAction gameActionObject;
    private Transform triggeredTransform;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = transform;
        gameActionObject.transformAction += HandleTransform;
    }

     public void HandleTransform(Transform obj)
    {
        if(triggeredTransform == obj)
        {
            destination = obj;
        }
    }

     private void OnTriggerEnter(Collider other)
    {
        triggeredTransform = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = transform;
        triggeredTransform = transform;
    }

    private void Update()
    {
        agent.destination = destination.position;
    }
    
}