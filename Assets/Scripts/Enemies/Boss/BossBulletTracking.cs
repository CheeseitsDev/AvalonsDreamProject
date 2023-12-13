using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ethan Hoare

public class BossBulletTracking : MonoBehaviour
{
    private Rigidbody2D rb;
    private float timer;
    private Health healthScript;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        healthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();

        StartCoroutine(DestroyBullet());
    }

    private void Update()
    {
        rb.AddForce(-transform.up * GameManager.Instance.bossForce);

        timer += Time.deltaTime;

        if(timer > 3)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            healthScript.DamagePlayer(GameManager.Instance.bossDamage);
            
            Destroy(gameObject);
        }
    }

    private IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(5f); 

        Destroy(gameObject);
    }
}
