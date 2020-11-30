using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Countdown : MonoBehaviour
{
    public UnityEvent countDownEvent;


    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(WaitTime());
    }

    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(20f);
        countDownEvent.Invoke();


    }

}
