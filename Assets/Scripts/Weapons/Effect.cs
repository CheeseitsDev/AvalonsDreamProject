using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ethan Hoare

public class Effect : MonoBehaviour
{
    private BossShoot bossShootScript;
    private float timer;

    private void Start()
    {
        bossShootScript = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossShoot>();
    }

    private void Update()
    {
       timer += Time.deltaTime;

        if(timer > 3)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Boss"))
        {
            bossShootScript.HitByEmp();

            Destroy(gameObject);
        }
    }
}
