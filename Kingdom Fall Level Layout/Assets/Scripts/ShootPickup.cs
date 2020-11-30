using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootPickup : MonoBehaviour
{
    public UnityEvent reloadTimeUpdate;
    

    private void OnTriggerEnter(Collider other)
    {
        reloadTimeUpdate.Invoke();

    }
}
