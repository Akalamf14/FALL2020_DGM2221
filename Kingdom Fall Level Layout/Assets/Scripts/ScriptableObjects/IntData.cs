using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public UnityEvent countdownEvent;

    public void TimerCountdown(int value)
    {
        value --;
        countdownEvent.Invoke();

    }
}
