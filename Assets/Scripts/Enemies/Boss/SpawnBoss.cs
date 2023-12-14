using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class SpawnBoss : MonoBehaviour
{
    public Collider2D collider1;
    public Collider2D collider2;
    public GameObject boss;
    public GameObject bossBar;
    public BossShoot bossShootScript;

    private void Start()
    {
        bossShootScript.enabled = false;
        boss.SetActive(false);
        bossBar.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Spawn();

            StartCoroutine(DisableTrigger());
        }
    }

    private IEnumerator DisableTrigger()
    {
        yield return new WaitForSeconds(1f);
        
        collider1.isTrigger = false;
        collider2.isTrigger = false;
    }

    private void Spawn()
    {
        bossShootScript.enabled = true;
        boss.SetActive(true);
        bossBar.SetActive(true);
    }
}
