using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Alessandro Napoli

public class ShieldBar : MonoBehaviour
{
    public Slider shieldBar;

    private void Start()
    {
        shieldBar = GetComponent<Slider>();
        shieldBar.maxValue = GameManager.Instance.playerMaxShieldCharges;
        shieldBar.value = GameManager.Instance.playerCurrentShieldCharge;
    }
    public void SetShield(int shield)
    {
        shieldBar.value = shield;
    }
}
