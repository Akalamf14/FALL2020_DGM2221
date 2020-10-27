using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructBehaviour : MonoBehaviour
{
    IEnumerator OnTriggerEnter()
    {
        yield return new WaitForSeconds(.1f);
        Destroy(gameObject);
    }

}
