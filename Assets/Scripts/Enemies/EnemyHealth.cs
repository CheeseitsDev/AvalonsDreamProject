using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ethan Hoare

public class EnemyHealth : MonoBehaviour
{
    public AudioSource hit;
    private Scrap scrapScript;
    private int health;

    private void Start()
    {
        health = GameManager.Instance.enemyHealth;

        scrapScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Scrap>();
    }

    void Update()
    {
        if(health <= 0)
        {
            scrapScript.IncreaseScrap(1);

            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damageamount)
    {
        hit.Play();

        health -= damageamount;
    }
}
