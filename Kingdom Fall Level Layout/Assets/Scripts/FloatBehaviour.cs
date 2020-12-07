using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloatBehaviour : MonoBehaviour
{
    public float value = 1f;

    public UnityEvent triggerEnterEvent, atZeroEvent;

    private void Start()
    {
        value = 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger entered");
        triggerEnterEvent.Invoke();
    }

    public void UpdateValue(float number)
    {
        value += number;

        if(value <= 0)
        {
            atZeroEvent.Invoke();
        }
       
    }

     
}

