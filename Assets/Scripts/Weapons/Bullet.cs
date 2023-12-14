using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    private BossHealth bossHealthScript;

    private void Start()
    {
        StartCoroutine(DestroyBullet()); //Starts timer

        bossHealthScript = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossHealth>();
    }

    private void Update()
    {
        BulletBehaviour();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boss")
        {
            if(WeaponManager.Instance.isPistolSelected)
            {
                bossHealthScript.TakeDamage(WeaponManager.Instance.pistolDamage);

                Destroy(gameObject);
            }
            else if(WeaponManager.Instance.isBurstRifleSelected)
            {
                bossHealthScript.TakeDamage(WeaponManager.Instance.burstRifleDamage);

                Destroy(gameObject);
            }
            else
            {
                bossHealthScript.TakeDamage(WeaponManager.Instance.shotgunDamage);

                Destroy(gameObject);
            }
        }

        if(collision.tag == "Enemy")
        {
            if(WeaponManager.Instance.isPistolSelected)
            {
                GameManager.Instance.enemyHealth -= WeaponManager.Instance.pistolDamage;

                Destroy(gameObject);
            }
            else if(WeaponManager.Instance.isBurstRifleSelected)
            {
                GameManager.Instance.enemyHealth -= WeaponManager.Instance.burstRifleDamage;

                Destroy(gameObject);
            }
            else
            {
                GameManager.Instance.enemyHealth -= WeaponManager.Instance.shotgunDamage;

                Destroy(gameObject);
            }
        }

        if(collision.tag == "Border")
        {
            Destroy(gameObject);
        }
    }

    private void BulletBehaviour()
    {
        rb.AddForce(transform.right * WeaponManager.Instance.bulletSpeed); //Moves bullet
    }

    private IEnumerator DestroyBullet() //Destroys bullet after 5 seconds
    {
        yield return new WaitForSeconds(5f); 

        Destroy(gameObject);
    }
}
