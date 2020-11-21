using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerShoot : MonoBehaviour
{
    public FloatData loadUpTime;
    public IntData ammoCount, ammoMax;
    public UnityEvent loadUpWeapon, coolDown;
    public GameObject prefab;
    public Transform instancer;
    public Image LoadUpImage;
    private bool canShoot = true;

    private void Start()
    {
        LoadUpImage.fillAmount = 0;
        loadUpTime.value = 0;
        ammoCount.value = 0;
    }

    private void Update()
    {

        if(Input.GetMouseButton(0))
        {
            LoadUpWeapon();
            if(loadUpTime.value >= 1f)
            {
                loadUpTime.value = 1f;
                ammoCount.value = ammoMax.value;
            }
            

        }

        if(Input.GetMouseButtonUp(0) && ammoCount.value > 0 && canShoot);
        {
            Fire();
            WeaponCoolDown();
            
            if(loadUpTime.value <= 0f)
            {
                loadUpTime.value = 0;
            }
        }
    }

    private void LoadUpWeapon()
    {
        loadUpWeapon.Invoke();
    }

    private void Fire()
    {
        ammoCount.value--;
    }

    private void WeaponCoolDown()
    {
        coolDown.Invoke();
    }

    
}

