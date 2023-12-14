using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Ashley Gentleman

public class PlayerUpgradeMenu : MonoBehaviour
{
    public GameObject playerUpgradeMenu;
    public GameObject selectPistolMenu;
    public GameObject selectBurstRifleMenu;
    public GameObject selectShotgunMenu;
    public Button healthTier1BTN;
    public Button healthTier2BTN;
    public Button healthTier3BTN;
    public Button healthTier4BTN;
    public Button healthTier5BTN;
    public Button shieldTier1BTN;
    public Button shieldTier2BTN;
    public Button shieldTier3BTN;
    public Button shieldTier4BTN;
    public Button shieldTier5BTN;
    public TMP_Text healthTier1TXT;
    public TMP_Text healthTier2TXT;
    public TMP_Text healthTier3TXT;
    public TMP_Text healthTier4TXT;
    public TMP_Text healthTier5TXT;
    public TMP_Text shieldTier1TXT;
    public TMP_Text shieldTier2TXT;
    public TMP_Text shieldTier3TXT;
    public TMP_Text shieldTier4TXT;
    public TMP_Text shieldTier5TXT;
    public TMP_Text scrap;
    private int tab;

    private void Start()
    {
        playerUpgradeMenu.SetActive(false);

        switch(GameManager.Instance.playerHealthUpgradeTier)
        {
            case 0:
                healthTier2BTN.interactable = false;
                healthTier3BTN.interactable = false;
                healthTier4BTN.interactable = false;
                healthTier5BTN.interactable = false;
                healthTier1BTN.interactable = true;
                break;
            case 1:
                healthTier1BTN.interactable = false;
                healthTier3BTN.interactable = false;
                healthTier4BTN.interactable = false;
                healthTier5BTN.interactable = false;
                healthTier2BTN.interactable = true;
                break;
            case 2:
                healthTier1BTN.interactable = false;
                healthTier2BTN.interactable = false;
                healthTier4BTN.interactable = false;
                healthTier5BTN.interactable = false;
                healthTier3BTN.interactable = true;
                break;
            case 3:
                healthTier1BTN.interactable = false;
                healthTier2BTN.interactable = false;
                healthTier3BTN.interactable = false;
                healthTier5BTN.interactable = false;
                healthTier4BTN.interactable = true;
                break;
            case 4:
                healthTier1BTN.interactable = false;
                healthTier2BTN.interactable = false;
                healthTier3BTN.interactable = false;
                healthTier4BTN.interactable = false;
                healthTier5BTN.interactable = true;
                break;
            case 5:
                healthTier1BTN.interactable = false;
                healthTier2BTN.interactable = false;
                healthTier3BTN.interactable = false;
                healthTier4BTN.interactable = false;
                healthTier5BTN.interactable = false;
                break;
        }

        switch(GameManager.Instance.playerShieldUpgradeTier)
        {
            case 0:
                shieldTier2BTN.interactable = false;
                shieldTier3BTN.interactable = false;
                shieldTier4BTN.interactable = false;
                shieldTier5BTN.interactable = false;
                shieldTier1BTN.interactable = true;
                break;
            case 1:
                shieldTier1BTN.interactable = false;
                shieldTier3BTN.interactable = false;
                shieldTier4BTN.interactable = false;
                shieldTier5BTN.interactable = false;
                shieldTier2BTN.interactable = true;
                break;
            case 2:
                shieldTier1BTN.interactable = false;
                shieldTier2BTN.interactable = false;
                shieldTier4BTN.interactable = false;
                shieldTier5BTN.interactable = false;
                shieldTier3BTN.interactable = true;
                break;
            case 3:
                shieldTier1BTN.interactable = false;
                shieldTier2BTN.interactable = false;
                shieldTier3BTN.interactable = false;
                shieldTier5BTN.interactable = false;
                shieldTier4BTN.interactable = true;
                break;
            case 4:
                shieldTier1BTN.interactable = false;
                shieldTier2BTN.interactable = false;
                shieldTier3BTN.interactable = false;
                shieldTier4BTN.interactable = false;
                shieldTier5BTN.interactable = true;
                break;
            case 5:
                shieldTier1BTN.interactable = false;
                shieldTier2BTN.interactable = false;
                shieldTier3BTN.interactable = false;
                shieldTier4BTN.interactable = false;
                shieldTier5BTN.interactable = false;
                break;
        }
    }

    private void Update()
    {
        scrap.text = "Scrap = " + GameManager.Instance.playerScrap.ToString();

        if(Input.GetKeyDown("e"))
        {
            GameManager.Instance.playerHealthUpgradeTier = 0;
            GameManager.Instance.playerShieldUpgradeTier = 0;
            GameManager.Instance.playerRegenSpeed = 10f;
            GameManager.Instance.playerShieldRegenSpeed = 60f;
            GameManager.Instance.playerMaxHealth = 100;
            GameManager.Instance.playerMaxShieldCharges = 0;

            healthTier2BTN.interactable = false;
            healthTier3BTN.interactable = false;
            healthTier4BTN.interactable = false;
            healthTier5BTN.interactable = false;
            healthTier1BTN.interactable = true;

            shieldTier2BTN.interactable = false;
            shieldTier3BTN.interactable = false;
            shieldTier4BTN.interactable = false;
            shieldTier5BTN.interactable = false;
            shieldTier1BTN.interactable = true;
        }
    }

    public void OpenFromPistol()
    {
        selectPistolMenu.SetActive(false);
        playerUpgradeMenu.SetActive(true);

        tab = 0;
    }

    public void OpenFromBurstRifle()
    {
        selectBurstRifleMenu.SetActive(false);
        playerUpgradeMenu.SetActive(true);

        tab = 1;
    }

    public void OpenFromShotgun()
    {
        selectShotgunMenu.SetActive(false);
        playerUpgradeMenu.SetActive(true);

        tab = 2;
    }

    public void Close()
    {
        switch(tab)
        {
            case 0:
                playerUpgradeMenu.SetActive(false);
                selectPistolMenu.SetActive(true);
                break;
            case 1:
                playerUpgradeMenu.SetActive(false);
                selectBurstRifleMenu.SetActive(true);
                break;
            case 2:
                playerUpgradeMenu.SetActive(false);
                selectShotgunMenu.SetActive(true);
                break;
        }
    }

    public void HealthTier1()
    {
        if(GameManager.Instance.playerScrap >= 5)
        {
            GameManager.Instance.playerScrap -= 5;
            GameManager.Instance.playerMaxHealth = 105;
            GameManager.Instance.playerHealthUpgradeTier = 1;

            healthTier1BTN.interactable = false;
            healthTier2BTN.interactable = true;
        }
        else
        {
            healthTier1TXT.text = "Not enough scrap";
        }
    }

    public void HealthTier2()
    {
        if(GameManager.Instance.playerScrap >= 10)
        {
            GameManager.Instance.playerScrap -= 10;
            GameManager.Instance.playerMaxHealth = 110;
            GameManager.Instance.playerHealthUpgradeTier = 2;

            healthTier2BTN.interactable = false;
            healthTier3BTN.interactable = true;
        }
        else
        {
            healthTier2TXT.text = "Not enough scrap";
        }
    }

    public void HealthTier3()
    {
        if(GameManager.Instance.playerScrap >= 15)
        {
            GameManager.Instance.playerScrap -= 15;
            GameManager.Instance.playerMaxHealth = 116;
            GameManager.Instance.playerHealthUpgradeTier = 3;

            healthTier3BTN.interactable = false;
            healthTier4BTN.interactable = true;
        }
        else
        {
            healthTier3TXT.text = "Not enough scrap";
        }
    }

    public void HealthTier4()
    {
        if(GameManager.Instance.playerScrap >= 20)
        {
            GameManager.Instance.playerScrap -= 20;
            GameManager.Instance.playerMaxHealth = 121;
            GameManager.Instance.playerHealthUpgradeTier = 4;

            healthTier4BTN.interactable = false;
            healthTier5BTN.interactable = true;
        }
        else
        {
            healthTier4TXT.text = "Not enough scrap";
        }
    }

    public void HealthTier5()
    {
        if(GameManager.Instance.playerScrap >= 25)
        {
            GameManager.Instance.playerScrap -= 25;
            GameManager.Instance.playerMaxHealth = 127;
            GameManager.Instance.playerHealthUpgradeTier = 5;

            GameManager.Instance.playerRegenSpeed = 9f;

            healthTier5BTN.interactable = false;
        }
        else
        {
            healthTier5TXT.text = "Not enough scrap";
        }
    }

    public void ShieldTier1()
    {
        if(GameManager.Instance.playerScrap >= 5)
        {
            GameManager.Instance.playerScrap -= 5;
            GameManager.Instance.playerMaxShieldCharges = 1;
            GameManager.Instance.playerShieldUpgradeTier = 1;

            shieldTier1BTN.interactable = false;
            shieldTier2BTN.interactable = true;
        }
        else
        {
            shieldTier1TXT.text = "Not enough scrap";
        }
    }

    public void ShieldTier2()
    {
        if(GameManager.Instance.playerScrap >= 10)
        {
            GameManager.Instance.playerScrap -= 10;
            GameManager.Instance.playerMaxShieldCharges = 2;
            GameManager.Instance.playerShieldUpgradeTier = 2;

            shieldTier2BTN.interactable = false;
            shieldTier3BTN.interactable = true;
        }
        else
        {
            shieldTier2TXT.text = "Not enough scrap";
        }
    }

    public void ShieldTier3()
    {
        if(GameManager.Instance.playerScrap >= 15)
        {
            GameManager.Instance.playerScrap -= 15;
            GameManager.Instance.playerMaxShieldCharges = 3;
            GameManager.Instance.playerShieldUpgradeTier = 3;

            shieldTier3BTN.interactable = false;
            shieldTier4BTN.interactable = true;
        }
        else
        {
            shieldTier3TXT.text = "Not enough scrap";
        }
    }

    public void ShieldTier4()
    {
        if(GameManager.Instance.playerScrap >= 20)
        {
            GameManager.Instance.playerScrap -= 20;
            GameManager.Instance.playerMaxShieldCharges = 4;
            GameManager.Instance.playerShieldUpgradeTier = 4;

            shieldTier4BTN.interactable = false;
            shieldTier5BTN.interactable = true;
        }
        else
        {
            shieldTier4TXT.text = "Not enough scrap";
        }
    }

    public void ShieldTier5()
    {
        if(GameManager.Instance.playerScrap >= 25)
        {
            GameManager.Instance.playerScrap -= 25;
            GameManager.Instance.playerMaxShieldCharges = 5;
            GameManager.Instance.playerShieldUpgradeTier = 5;

            GameManager.Instance.playerShieldRegenSpeed = 54f;

            shieldTier5BTN.interactable = false;
        }
        else
        {
            shieldTier5TXT.text = "Not enough scrap";
        }
    }
}
