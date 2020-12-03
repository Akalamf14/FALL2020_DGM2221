using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Wander : MonoBehaviour
{
    //Wander
    public float wanderRadius;
    public float wanderTime;

    public Transform target;
    private NavMeshAgent agent;
    private float timer;


    //Detection
    public float speed;
    public float alertDist;
    public float attackDist;
    private float distance;

    private Vector3 heading;


    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTime;
    }

    void Start()
    {
        //distance = Vector3.Distance(target.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            distance = Vector3.Distance(target.position, transform.position);

        }
        
        //alert
        if(distance < alertDist && distance > attackDist)
        {
            print("Enemy sees target");
            speed += 2;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        //Following
        else if(distance <= alertDist)
        {
            print("Enemy is following");
            heading = target.position - transform.position;
            heading.y = 0;
            speed -= 100;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);


            if(heading.magnitude <= attackDist)
            {
                print("Enemy is attacking");
                //var health = target.gameObject.GetComponent<PlayerHealth>();

                //if(health != null)
                //{
                    //health.TakeDamage(damage);
                //}
            }
        }

        //Wandering
        else if(distance > alertDist)
        {

            timer += Time.deltaTime;

            if(timer >= wanderTime)
            {
                Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                agent.SetDestination(newPos);
                timer = 0;
            }
        }
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
