using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public FloatData damage;
    public Transform target;

    public FloatData moveSpeed;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            transform.LookAt(target);
            transform.Translate(Vector3.forward * moveSpeed.value * Time.deltaTime);
        }
    }

    
    void OnCollisionEnter(Collision other)
    {
        print("Enemy is Attacking!");
        var health = other.gameObject.GetComponent<PlayerHealth>();

        if (health != null)
        {
            health.TakeDamage(damage);
        }
    }
}
