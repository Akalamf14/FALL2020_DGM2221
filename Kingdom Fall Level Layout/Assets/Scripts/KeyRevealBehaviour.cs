using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class KeyRevealBehaviour : MonoBehaviour
{
    public IntData keyValue;
    public UnityEvent startEvent, revealEvent;
    public int maxValue;

    private void Start()
    {
        startEvent.Invoke();
        keyValue.value = 0;
    }

    private void OnEnable()
    {
        if(keyValue.value >= maxValue)
        {
            revealEvent.Invoke();
        }
    }


}