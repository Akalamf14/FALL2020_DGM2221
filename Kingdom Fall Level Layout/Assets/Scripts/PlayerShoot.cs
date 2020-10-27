using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{
    public int ammoCount;
    public int maxAmmo = 10;
    public GameObject prefab;
    public Transform instancer;
    public float reloadTime;
    public WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    public Image coolDownImage;
    private bool canShoot = true;
    

    private void Start()
    {
        coolDownImage.fillAmount = 0;
        ammoCount = maxAmmo;
        

    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && ammoCount > 0 && canShoot)
        {
            Fire();
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(reload());
        }
    }

    private void Fire()
    {
        Instantiate(prefab, instancer.position, instancer.rotation);
        ammoCount--;

        if(ammoCount == 0)
        {
            StartCoroutine(reload());
        }
    }

    private IEnumerator reload()
    {
        canShoot = false;
        var countDown = reloadTime;

        while(countDown > 0)
        {
            yield return wffu;
            countDown -=.01f;
            coolDownImage.fillAmount = countDown / reloadTime;
        }
        
        ammoCount = maxAmmo;
        canShoot = true;
    }
}
