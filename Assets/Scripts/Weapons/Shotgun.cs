using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman st20266734

public class Shotgun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePoint1;
    public GameObject firePoint2;
    public GameObject firePoint3;
    public AudioSource shotgunAudioSource;
    public AudioSource outOfAmmoAudioSource;
    private bool canShoot = true;

    private void Start()
    {
        WeaponManager.Instance.shotgunCurrentClip = WeaponManager.Instance.shotgunClip;
        WeaponManager.Instance.shotgunUpgradeTier = 0;
    }

    private void Update()
    {
        if(!WeaponManager.Instance.isShotgunMastered)
        {
            Shoot();
        }
        else
        {
            MasteredShoot();
        }

        if(WeaponManager.Instance.shotgunCurrentClip <= 0)
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

        if(!canShoot)
        {
            StartCoroutine(ShootDelay());
        }
    }

    private void Reload()
    {
        if(WeaponManager.Instance.shotgunReserve >= WeaponManager.Instance.shotgunClip)
        {
            WeaponManager.Instance.shotgunReserve -= WeaponManager.Instance.shotgunClip;
            WeaponManager.Instance.shotgunCurrentClip = WeaponManager.Instance.shotgunClip;

            canShoot = true;
        }
        else
        {
            WeaponManager.Instance.shotgunCurrentClip = WeaponManager.Instance.shotgunReserve;
            WeaponManager.Instance.shotgunReserve -= WeaponManager.Instance.shotgunCurrentClip;
            
            canShoot = true;
        }
    }

    private void Shoot()
    {
        if(WeaponManager.Instance.shotgunCurrentClip > 0 && canShoot)
        {
            if(Input.GetMouseButtonDown(0))
            {
                shotgunAudioSource.Play();

                canShoot = false;

                WeaponManager.Instance.shotgunCurrentClip -= 3;

                Instantiate(bulletPrefab, firePoint1.transform.position, firePoint1.transform.rotation);
                Instantiate(bulletPrefab, firePoint2.transform.position, firePoint2.transform.rotation);
                Instantiate(bulletPrefab, firePoint3.transform.position, firePoint3.transform.rotation);
            }
        }
    }

    private void MasteredShoot()
    {
        if(canShoot)
        {
            if(Input.GetMouseButtonDown(0))
            {
                shotgunAudioSource.Play();

                WeaponManager.Instance.shotgunCurrentClip -= 6;

                StartCoroutine(MasteredShotgunBurst());
            }
        }
    }

    private IEnumerator MasteredShotgunBurst()
    {
        Instantiate(bulletPrefab, firePoint1.transform.position, firePoint1.transform.rotation);
        Instantiate(bulletPrefab, firePoint2.transform.position, firePoint2.transform.rotation);    
        Instantiate(bulletPrefab, firePoint3.transform.position, firePoint3.transform.rotation);

        yield return new WaitForSeconds(0.5f);

        Instantiate(bulletPrefab, firePoint1.transform.position, firePoint1.transform.rotation);
        Instantiate(bulletPrefab, firePoint2.transform.position, firePoint2.transform.rotation);
        Instantiate(bulletPrefab, firePoint3.transform.position, firePoint3.transform.rotation);

        canShoot = false;
    }

    private IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(WeaponManager.Instance.shotgunShootDelay);

        canShoot = true;
    }
}
