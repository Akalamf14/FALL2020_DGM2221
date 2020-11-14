using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerBehaviour : MonoBehaviour
{
    public Color defaultColor, newColor;
    private MeshRenderer meshR;

    private WaitForSeconds wfs;
    public int holdTime = 10;
    public GameObject door;
    public TimerUI timer;

    void Start()
    {
        meshR = GetComponent<MeshRenderer>();
        meshR.material.color = defaultColor;

        wfs = new WaitForSeconds(holdTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        newColor.a = 0.5f;
        meshR.material.color = newColor;

        door.SetActive(false);
    }

    private IEnumerator OnTriggerExit(Collider other)
    {
        StartCoroutine(timer.Countdown());
        yield return wfs;
        meshR.material.color = defaultColor;
        door.SetActive(true);
    }
    


}
