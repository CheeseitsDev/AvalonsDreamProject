using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Ethan Hoare st20271423

public class BossHealth : MonoBehaviour
{
    // public Image bossHealthBar;
    private bool isBossDead;

    private void Start()
    {
        GameManager.Instance.bossHealth = GameManager.Instance.maxBossHealth;
    }

    public void takeDamage(int damageamount)
    {
        GameManager.Instance.bossHealth -= damageamount;
    }
    
    void Update()
    {
        // bossHealthBar.fillAmount = Mathf.Clamp(GameManager.Instance.bossHealth / GameManager.Instance.maxBossHealth, 0, 1);
        if(GameManager.Instance.bossHealth <= 0 && !isBossDead)
        {
            Destroy(gameObject) ;
            gameObject.SetActive(false);       
        }
    }
}
