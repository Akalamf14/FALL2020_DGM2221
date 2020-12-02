using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public UnityEvent countdownEvent, updateValueEvent;

    public void TimerCountdown(int value)
    {
        value --;
        countdownEvent.Invoke();

    }

    public void UpdateValue(int number)
    {
        value += number;
        updateValueEvent.Invoke();
    }
}
