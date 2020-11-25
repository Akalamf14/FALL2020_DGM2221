using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ObjectPickupBehaviour : MonoBehaviour
{
    private Rigidbody rBody;
    private bool canPickup;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        canPickup = Input.GetKey(KeyCode.F);
    }


    private void OnTriggerStay(Collider other)
    {
        if(canPickup)
        {
            transform.parent = other.transform;
            rBody.Sleep();

        }
        else
        {
            transform.parent = null;
            rBody.WakeUp();

        }
        
    }
}
