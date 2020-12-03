using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIMovement : MonoBehaviour
{
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private NavMeshAgent agent;
    public Transform destination;
    private bool canHunt, canPatrol;

    public float wanderRadius;
    

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Patrol());
        
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        canHunt = true;
        canPatrol = false;
        agent.destination = destination.position;
        var distance = agent.remainingDistance;
        while(distance <= 0.25f)
        {
            distance = agent.remainingDistance;
            yield return wffu;
        }

        yield return new WaitForSeconds(2f);

        StartCoroutine(canHunt ? OnTriggerEnter(other) : Patrol());
    }

    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
        StartCoroutine(Patrol());
    }

    private IEnumerator Patrol()
    {
        canPatrol = true;
        while(canPatrol)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            yield return wffu;
        }
        yield return new WaitForSeconds(1f);
    }



   public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}
