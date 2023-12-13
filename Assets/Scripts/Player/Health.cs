using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Alessandro Napoli

public class Health : MonoBehaviour
{
    public HealthBar healthBar;
    void Start()
    {
        GameManager.Instance.playerCurrentHealth = GameManager.Instance.playerMaxHealth;
    }
    void Update()
    {
        if(GameManager.Instance.playerCurrentHealth < GameManager.Instance.playerMaxHealth)
        {
            StartCoroutine(Regen());
        }

        if(GameManager.Instance.playerCurrentHealth <= 0)
        {
            SceneManager.LoadScene("GameOverScreen");
        }
    }

    private IEnumerator Regen()
    {
        yield return new WaitForSeconds(GameManager.Instance.playerRegenSpeed);

        if(GameManager.Instance.playerCurrentHealth < GameManager.Instance.playerMaxHealth)
        {
            GameManager.Instance.playerCurrentHealth += 1;
            healthBar.SetHealth(GameManager.Instance.playerCurrentHealth);
        }
    }
    
    public void DamagePlayer(int damage)
    {
        GameManager.Instance.playerCurrentHealth -= damage;
        healthBar.SetHealth(GameManager.Instance.playerCurrentHealth);
    }
}

