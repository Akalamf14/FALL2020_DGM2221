using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class KeyRevealBehaviour : MonoBehaviour
{
    public List<int> objList;
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }

    public void KeyReveal()
    {
        objList.Remove(1);
    }


}