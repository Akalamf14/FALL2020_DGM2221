using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    
    private Rigidbody enemyRb;
    public float moveSpeed;

    public int damage;

   
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

        //target = GameObject.Find("Player").transform;

        //player = GameObject.Find("Player");
    }

    
    void Update()
    {
        //transform.LookAt(target);
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        enemyRb.AddForce((player.transform.position - transform.position).normalized  *  moveSpeed);
    }

    void OnCollisionEnter(Collision other)
    {
        /*
        if(other.gameObject.CompareTag("Player"))
        {
            var hit = other.gameObject;
            var health = hit.GetComponent<PlayerHealth>();

            if(health != null)
            {
                health.TakeDamage(damage);
                Debug.Log("Player Has Been Hit");
            }
        }
        */
    }
}
