using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class SpawnBoss : MonoBehaviour
{
    public GameObject boss;
    public GameObject bossBar;
    public BossShoot bossShootScript;

    private void Start()
    {
        bossShootScript.enabled = false;
        boss.SetActive(false);
        bossBar.SetActive(false);
    }

    private void Update()
    {
        if(GameManager.Instance.playerKills >= 10)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        bossShootScript.enabled = true;
        boss.SetActive(true);
        bossBar.SetActive(true);
    }
}
