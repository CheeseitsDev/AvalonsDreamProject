using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Alessandro Napoli st20269559

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;

    private void Start()
    {
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = GameManager.Instance.playerMaxHealth;
        healthBar.value = GameManager.Instance.playerCurrentHealth;
    }
    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}
