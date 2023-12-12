using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman st20266734

public class BurstRifle : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePoint;
    public GameObject masteredFirePoint1;
    public GameObject masteredFirePoint2;
    public AudioSource burstRifleAudioSource;
    public AudioSource outOfAmmoAudioSource;
    private bool canShoot = true;

    private void Start()
    {
        WeaponManager.Instance.burstRifleCurrentClip = WeaponManager.Instance.burstRifleClip;
        WeaponManager.Instance.burstRifleUpgradeTier = 0;
    }

    private void Update()
    {
        if(!WeaponManager.Instance.isBurstRifleMastered)
        {
            Shoot();
        }
        else
        {
            MasteredShoot();
        }

        if(WeaponManager.Instance.burstRifleCurrentClip <= 0)
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
        if(WeaponManager.Instance.burstRifleReserve >= WeaponManager.Instance.burstRifleClip)
        {
            WeaponManager.Instance.burstRifleReserve -= WeaponManager.Instance.burstRifleClip;
            WeaponManager.Instance.burstRifleCurrentClip = WeaponManager.Instance.burstRifleClip;

            canShoot = true;
        }
        else
        {
            WeaponManager.Instance.burstRifleCurrentClip = WeaponManager.Instance.burstRifleReserve;
            WeaponManager.Instance.burstRifleReserve -= WeaponManager.Instance.burstRifleCurrentClip;
            
            canShoot = true;
        }
    }

    private void MasteredShoot()
    {
        if(canShoot)
        {
            if(Input.GetMouseButtonDown(0))
            {
                canShoot = false;

                StartCoroutine(MasteredBurst());
            }
        }
    }

    private void Shoot()
    {
        if(canShoot)
        {
            if(Input.GetMouseButtonDown(0))
            {
                canShoot = false;

                StartCoroutine(Burst());
            }
        }
    }

    private IEnumerator MasteredBurst()
    {
        WeaponManager.Instance.burstRifleCurrentClip -= 2;

        burstRifleAudioSource.Play();

        Instantiate(bulletPrefab, masteredFirePoint1.transform.position, masteredFirePoint1.transform.rotation);
        Instantiate(bulletPrefab, masteredFirePoint2.transform.position, masteredFirePoint2.transform.rotation);

        yield return new WaitForSeconds(0.5f);

        WeaponManager.Instance.burstRifleCurrentClip -= 2;

        burstRifleAudioSource.Play();

        Instantiate(bulletPrefab, masteredFirePoint1.transform.position, masteredFirePoint1.transform.rotation);
        Instantiate(bulletPrefab, masteredFirePoint2.transform.position, masteredFirePoint2.transform.rotation);

        yield return new WaitForSeconds(0.5f);

        WeaponManager.Instance.burstRifleCurrentClip -= 2;

        burstRifleAudioSource.Play();

        Instantiate(bulletPrefab, masteredFirePoint1.transform.position, masteredFirePoint1.transform.rotation);
        Instantiate(bulletPrefab, masteredFirePoint2.transform.position, masteredFirePoint2.transform.rotation);
        
        StartCoroutine(ShootDelay());
    }

    private IEnumerator Burst()
    {
        WeaponManager.Instance.burstRifleCurrentClip -= 1;

        burstRifleAudioSource.Play();

        Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);

        yield return new WaitForSeconds(0.5f);

        WeaponManager.Instance.burstRifleCurrentClip -= 1;

        burstRifleAudioSource.Play();

        Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);

        yield return new WaitForSeconds(0.5f);

        WeaponManager.Instance.burstRifleCurrentClip -= 1;

        burstRifleAudioSource.Play();

        Instantiate(bulletPrefab, firePoint.transform.position, firePoint.transform.rotation);
        
        StartCoroutine(ShootDelay());
    }

    private IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(WeaponManager.Instance.burstRifleShootDelay);

        canShoot = true;
    }
}
