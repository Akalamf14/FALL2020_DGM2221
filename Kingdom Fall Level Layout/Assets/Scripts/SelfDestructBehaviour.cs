using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructBehaviour : MonoBehaviour
{
    public float lifeTime = 3f;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

}
