using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Adam Thomas

public class EnemyShoot : MonoBehaviour
{
    public AudioSource shoot;
    public GameObject enemyBullet;
    public Transform firePoint;
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

        Instantiate(enemyBullet, firePoint.position, firePoint.rotation);
    }
}
