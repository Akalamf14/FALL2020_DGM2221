using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerShoot : MonoBehaviour
{
    public float loadUpTime;
    public float coolDown;
    public UnityEvent loadUpWeapon;
    public GameObject prefab;
    public Transform instancer;
    public WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    public Image LoadUpImage;
    private bool canShoot;

    private void Start()
    {
        LoadUpImage.fillAmount = 0;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LoadUpWeapon();

        }

        if(Input.GetMouseButtonUp(0) && loadUpTime = 1f)
        {
            Fire();
            StartCoroutine(CoolDown());
            canShoot = true;
        }
    }

    private void LoadUpWeapon()
    {
        loadUpWeapon.Invoke();
    }

    /*private void Fire();
    {
        Instantiate(prefab, instancer.position, instancer.rotation);
    
        StartCoroutine(CoolDown());

    }
    */

    private IEnumerator CoolDown()
    {
        canShoot = false;
        var countDown = coolDown;

        while(countDown > 0)
        {
            yield return wffu;
            countDown -= .01f;
            LoadUpImage.fillAmount = countDown / coolDown;
        }

        canShoot = true;

    }
}
