using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ethan Hoare

public class EnemyHealth : MonoBehaviour
{
    public AudioSource hit;
    private Scrap scrapScript;
    private int health;
    private int random;

    private void Start()
    {
        random = Random.Range(0, 2);

        Debug.Log(random);

        health = GameManager.Instance.enemyHealth;

        scrapScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Scrap>();
    }

    void Update()
    {
        if(health <= 0)
        {
            scrapScript.IncreaseScrap(1);

            if(random == 1)
            {
                WeaponManager.Instance.pistolReserve += 2;
                WeaponManager.Instance.burstRifleReserve += 3;
                WeaponManager.Instance.shotgunReserve += 3;
            }
            
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damageamount)
    {
        hit.Play();

        health -= damageamount;
    }
}
