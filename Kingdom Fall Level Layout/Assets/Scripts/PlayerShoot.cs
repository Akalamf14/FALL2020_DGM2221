using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerShoot : MonoBehaviour
{
    public IntData ammoCount, maxAmmo;
    public GameObject prefab;
    public Transform instancer;
    public float reloadTime;
    public WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    public Image coolDownImage;
    private bool canShoot = true;


    private void Start()
    {
        coolDownImage.fillAmount = 0;
        ammoCount.value = maxAmmo.value;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && ammoCount.value > 0)
        {
            Fire();
            StartCoroutine(reload());
        }
    }



    private void Fire()
    {
        Instantiate(prefab, instancer.position, instancer.rotation);
        ammoCount.value--;
    }

    private IEnumerator reload()
    {
        canShoot = false;
        var countDown = reloadTime.value;

        while(countDown > 0)
        {
            yield return wffu;
            countDown -= .01f;
            coolDownImage.fillAmount = countDown / reloadTime;
        }

        ammoCount.value = maxAmmo.value;
    }

    
}

