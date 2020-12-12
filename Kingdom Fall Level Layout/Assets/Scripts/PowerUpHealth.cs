using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpHealth : MonoBehaviour
{
    public float enablePowerUp;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
 
        }
    }

    IEnumerator Pickup(Collider player)
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(enablePowerUp);

        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<MeshRenderer>().enabled = true;
        

        
        
        
    }
}
