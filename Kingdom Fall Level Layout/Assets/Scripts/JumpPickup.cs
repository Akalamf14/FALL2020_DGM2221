using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpPickup : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public FloatData jumpForceChange;


    private void OnTriggerEnter(Collider other)
    {
        jumpForceChange.value = 5.5f;
        
        triggerEnterEvent.Invoke();
        

    }

}
