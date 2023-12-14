using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    private BossHealth bossHealthScript;
    private EnemyHealth enemyHealthScript;

    private void Start()
    {
        StartCoroutine(DestroyBullet()); //Starts timer

        bossHealthScript = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossHealth>();
        enemyHealthScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyHealth>();
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
                enemyHealthScript.TakeDamage(WeaponManager.Instance.pistolDamage);

                Destroy(gameObject);
            }
            else if(WeaponManager.Instance.isBurstRifleSelected)
            {
                enemyHealthScript.TakeDamage(WeaponManager.Instance.burstRifleDamage);

                Destroy(gameObject);
            }
            else
            {
                enemyHealthScript.TakeDamage(WeaponManager.Instance.shotgunDamage);

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
