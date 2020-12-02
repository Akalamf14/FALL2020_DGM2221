/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloatBehaviour : MonoBehaviour
{
    public float value = 1f;

    public UnityEvent triggerEnterEvent, atZeroEvent;

    private void OnTriggerEnter(Collider other)
    {
        var otherValue = other.GetComponent<FloatHolder>();
        if(nullCheck != null) return;
        UpdateValue(otherValue);
        triggerEnterEvent.Invoke();
    }

    public void UpdateValue(float number)
    {
        value += number;

        if(value < 0)
        {
            atZeroEvent.Invoke();
        }
    }
}
*/
