using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject bullet;

    public float fireRate;
    public float nextFire;


    private void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }

    private void OnTriggerStay(Collider other)
    {
        CheckIfTimeToFire();
    }

    private void CheckIfTimeToFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
