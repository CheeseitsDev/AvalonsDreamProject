using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Ethan Hoare

public class BossHealth : MonoBehaviour
{
    public AudioSource hit;
    public Slider bossBar;
    private bool isBossDead;
    private Scrap scrapScript;

    private void Start()
    {
        bossBar.maxValue = GameManager.Instance.maxBossHealth;
        bossBar.value = GameManager.Instance.bossHealth;

        GameManager.Instance.bossHealth = GameManager.Instance.maxBossHealth;

        scrapScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Scrap>();
    }

    public void TakeDamage(int damageamount)
    {
        hit.Play();

        GameManager.Instance.bossHealth -= damageamount;
    }
    
    void Update()
    {
        SetHealth(GameManager.Instance.bossHealth);

        if(GameManager.Instance.bossHealth <= 0 && !isBossDead)
        {
            scrapScript.IncreaseScrap(5);

            SceneManager.LoadScene("WinScreen");
        }
    }

    public void SetHealth(int hp)
    {
        bossBar.value = hp;
    }
}
