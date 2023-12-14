using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ethan Hoare

public class BossShoot : MonoBehaviour
{
    public AudioSource shoot;
    public GameObject bossbullet;
    public Transform bulletpos;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            timer = 0;
            Shoot();
        }
    }

    public void HitByEmp() 
    {
        timer = -4;
    }

    private void Shoot()
    {
        shoot.Play();

        Instantiate(bossbullet, bulletpos.position, bulletpos.rotation);
    }
}
