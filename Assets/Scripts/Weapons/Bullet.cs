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
            }
            else if(WeaponManager.Instance.isBurstRifleSelected)
            {
                bossHealthScript.TakeDamage(WeaponManager.Instance.burstRifleDamage);
            }
            else
            {
                bossHealthScript.TakeDamage(WeaponManager.Instance.shotgunDamage);
            }
        }
    }

    private void BulletBehaviour()
    {
        rb.AddForce(transform.up * WeaponManager.Instance.bulletSpeed); //Moves bullet
    }

    private IEnumerator DestroyBullet() //Destroys bullet after 5 seconds
    {
        yield return new WaitForSeconds(5f); 

        Destroy(gameObject);
    }
}
