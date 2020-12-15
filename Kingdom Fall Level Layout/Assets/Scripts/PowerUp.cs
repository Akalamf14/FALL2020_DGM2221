using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public FloatData jumpForce;

    public float returnToNormalJump, enablePowerUp;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
 
        }
    }

    IEnumerator Pickup(Collider player)
    {
        jumpForce.value = 5.5f;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(returnToNormalJump);

        jumpForce.value = 3.5f;

        yield return new WaitForSeconds(enablePowerUp);

        GetComponent<MeshRenderer>().enabled = true;
        GetComponent<Collider>().enabled = true;
        

        
        
        
    }
}
