using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Alessandro Napoli st20269559

public class Health : MonoBehaviour
{
    public HealthBar healthBar;
    void Start()
    {
        GameManager.Instance.playerCurrentHealth = GameManager.Instance.playerMaxHealth;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //This was just a test to check if the hp will go down, cancel when we have an actual scene
        {
            DamagePlayer(10);
        }

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
        yield return new WaitForSeconds(10f);

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

