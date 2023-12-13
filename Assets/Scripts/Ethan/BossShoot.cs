using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ethan Hoare st20271423

public class BossShoot : MonoBehaviour
{
    public GameObject bossbullet;
    public Transform bulletpos;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            timer = 0;
            shoot();
        }
    }

    public void hitByEmp() 
    {
        timer = -4;
    }

    private void shoot()
    {
        Instantiate(bossbullet, bulletpos.position, bulletpos.rotation);
    }
}
