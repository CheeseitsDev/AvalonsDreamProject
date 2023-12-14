using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Alessandro Napoli

public class Health : MonoBehaviour
{
    public AudioSource hit;
    public HealthBar healthBar;
    public ShieldBar shieldBar;

    void Start()
    {
        GameManager.Instance.playerCurrentHealth = GameManager.Instance.playerMaxHealth;
        GameManager.Instance.playerMaxShieldCharges = GameManager.Instance.playerCurrentShieldCharge;
    }
    void Update()
    {
        if(GameManager.Instance.playerCurrentHealth < GameManager.Instance.playerMaxHealth)
        {
            StartCoroutine(Regen());
        }

        if(GameManager.Instance.playerCurrentShieldCharge < GameManager.Instance.playerMaxShieldCharges)
        {
            StartCoroutine(RegenShield());
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

    private IEnumerator RegenShield()
    {
        yield return new WaitForSeconds(GameManager.Instance.playerShieldRegenSpeed);

        if(GameManager.Instance.playerCurrentShieldCharge < GameManager.Instance.playerMaxShieldCharges)
        {
            GameManager.Instance.playerCurrentShieldCharge += 1;
            shieldBar.SetShield(GameManager.Instance.playerCurrentShieldCharge);
        }
    }
    
    public void DamagePlayer(int damage)
    {
        if(GameManager.Instance.playerCurrentShieldCharge >= 1)
        {
            hit.Play();
            UseShield();
        }
        else
        {
            hit.Play();
            GameManager.Instance.playerCurrentHealth -= damage;
            healthBar.SetHealth(GameManager.Instance.playerCurrentHealth);
        }
    }

    private void UseShield()
    {
        GameManager.Instance.playerCurrentShieldCharge -= 1;
    }
}

