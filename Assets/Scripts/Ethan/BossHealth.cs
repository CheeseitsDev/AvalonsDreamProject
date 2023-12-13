using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Ethan Hoare st20271423

public class BossHealth : MonoBehaviour
{
    public Slider bossBar;
    private bool isBossDead;

    private void Start()
    {
        bossBar.maxValue = GameManager.Instance.maxBossHealth;
        bossBar.value = GameManager.Instance.bossHealth;

        GameManager.Instance.bossHealth = GameManager.Instance.maxBossHealth;
    }

    public void TakeDamage(int damageamount)
    {
        GameManager.Instance.bossHealth -= damageamount;
    }
    
    void Update()
    {
        SetHealth(GameManager.Instance.bossHealth);

        if(GameManager.Instance.bossHealth <= 0 && !isBossDead)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    public void SetHealth(int hp)
    {
        bossBar.value = hp;
    }
}
