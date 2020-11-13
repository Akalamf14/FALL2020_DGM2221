using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructBehaviour : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

}
