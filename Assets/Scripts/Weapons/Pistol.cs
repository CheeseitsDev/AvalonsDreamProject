using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class Pistol : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePoint;
    public AudioSource pistolAudioSource;
    public AudioSource outOfAmmoAudioSource;
    private bool canShoot = true;

    private void Start()
    {
        WeaponManager.Instance.pistolCurrentClip = WeaponManager.Instance.pistolClip; //Sets the guns current ammo to full at the start of the game
        WeaponManager.Instance.pistolUpgradeTier = 0;
    }

    private void Update()
    {
        if(!WeaponManager.Instance.isPistolMastered)
        {
            Shoot();
        }
        else
        {
            MasteredShoot();
        }


        if(WeaponManager.Instance.pistolCurrentClip <= 0)
        {
            canShoot = false;

            if(Input.GetMouseButtonDown(0))
            {
                outOfAmmoAudioSource.Play();
            }

            if(Input.GetKeyDown("r"))
            {
                Reload();
            }
        }
    }

    private void Reload()
    {
        if(WeaponManager.Instance.pistolReserve >= WeaponManager.Instance.pistolClip)
        {

            WeaponManager.Instance.pistolReserve -= WeaponManager.Instance.pistolClip;
            WeaponManager.Instance.pistolCurrentClip = WeaponManager.Instance.pistolClip;

            canShoot = true;
        }
        else
        {

            WeaponManager.Instance.pistolCurrentClip = WeaponManager.Instance.pistolReserve;
            WeaponManager.Instance.pistolReserve -= WeaponManager.Instance.pistolCurrentClip;
            
            canShoot = true;
        }
    }   

    private void Shoot()
    {
        if(canShoot)
        {
            if(Input.GetMouseButtonDown(0)) //Allows the player to spam left clip
            {
                pistolAudioSource.Play();

                WeaponManager.Instance.pistolCurrentClip -= 1;

                canShoot = false;

                Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation); //Spawns bullet from the prefab folder at the firepoints position and rotation

                StartCoroutine(ShootDelay()); //Starts timer
            }
        }
    }

    private void MasteredShoot()
    {
        if(WeaponManager.Instance.pistolCurrentClip > 0 && canShoot)
        {
            if(Input.GetMouseButton(0)) //Allows the player to hold down left click to shoot
            {
                pistolAudioSource.Play();

                WeaponManager.Instance.pistolCurrentClip -= 1;

                canShoot = false;

                Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);

                StartCoroutine(ShootDelay()); //Starts timer
            }
        }
    }

    private IEnumerator ShootDelay() //Makes player wait 0.5 seconds between firing
    {
        yield return new WaitForSeconds(WeaponManager.Instance.pistolShootDelay);

        canShoot = true;
    }
}