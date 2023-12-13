using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Ashley Gentleman

public class UpgradeMenu : MonoBehaviour
{
    public GameObject pistolSelect;
    public GameObject burstRifleSelect;
    public GameObject shotgunSelect;
    public GameObject pistolUpgradeScereen;
    public GameObject burstRifleUpgradeScreen;
    public GameObject shotgunUpgradeScreen;
    public Button pistolTier1BTN;
    public Button pistolTier2BTN;
    public Button pistolTier3BTN;
    public Button pistolTier4BTN;
    public Button pistolTier5BTN;
    public Button burstRifleTier1BTN;
    public Button burstRifleTier2BTN;
    public Button burstRifleTier3BTN;
    public Button burstRifleTier4BTN;
    public Button burstRifleTier5BTN;
    public Button shotgunTier1BTN;
    public Button shotgunTier2BTN;
    public Button shotgunTier3BTN;
    public Button shotgunTier4BTN;
    public Button shotgunTier5BTN;
    public TMP_Text pistolTier1TXT;
    public TMP_Text pistolTier2TXT;
    public TMP_Text pistolTier3TXT;
    public TMP_Text pistolTier4TXT;
    public TMP_Text pistolTier5TXT;
    public TMP_Text burstRifleTier1TXT;
    public TMP_Text burstRifleTier2TXT;
    public TMP_Text burstRifleTier3TXT;
    public TMP_Text burstRifleTier4TXT;
    public TMP_Text burstRifleTier5TXT;
    public TMP_Text shotgunTier1TXT;
    public TMP_Text shotgunTier2TXT;
    public TMP_Text shotgunTier3TXT;
    public TMP_Text shotgunTier4TXT;
    public TMP_Text shotgunTier5TXT;
    public TMP_Text scrap1;
    public TMP_Text scrap2;
    public TMP_Text scrap3;

    private void Start()
    {
        switch(WeaponManager.Instance.pistolUpgradeTier)
        {
            case 0:
                pistolTier2BTN.interactable = false;
                pistolTier3BTN.interactable = false;
                pistolTier4BTN.interactable = false;
                pistolTier5BTN.interactable = false;
                pistolTier1BTN.interactable = true;
                break;
            case 1:
                pistolTier1BTN.interactable = false;
                pistolTier3BTN.interactable = false;
                pistolTier4BTN.interactable = false;
                pistolTier5BTN.interactable = false;
                pistolTier2BTN.interactable = true;
                break;
            case 2:
                pistolTier1BTN.interactable = false;
                pistolTier2BTN.interactable = false;
                pistolTier4BTN.interactable = false;
                pistolTier5BTN.interactable = false;
                pistolTier3BTN.interactable = true;
                break;
            case 3:
                pistolTier1BTN.interactable = false;
                pistolTier2BTN.interactable = false;
                pistolTier3BTN.interactable = false;
                pistolTier5BTN.interactable = false;
                pistolTier4BTN.interactable = true;
                break;
            case 4:
                pistolTier1BTN.interactable = false;
                pistolTier2BTN.interactable = false;
                pistolTier3BTN.interactable = false;
                pistolTier4BTN.interactable = false;
                pistolTier5BTN.interactable = true;
                break;
            case 5:
                pistolTier1BTN.interactable = false;
                pistolTier2BTN.interactable = false;
                pistolTier3BTN.interactable = false;
                pistolTier4BTN.interactable = false;
                pistolTier5BTN.interactable = false;

                WeaponManager.Instance.isPistolMastered = true;
                break;
        }

        switch(WeaponManager.Instance.burstRifleUpgradeTier)
        {
            case 0:
                burstRifleTier2BTN.interactable = false;
                burstRifleTier3BTN.interactable = false;
                burstRifleTier4BTN.interactable = false;
                burstRifleTier5BTN.interactable = false;
                burstRifleTier1BTN.interactable = true;
                break;
            case 1:
                burstRifleTier1BTN.interactable = false;
                burstRifleTier3BTN.interactable = false;
                burstRifleTier4BTN.interactable = false;
                burstRifleTier5BTN.interactable = false;
                burstRifleTier2BTN.interactable = true;
                break;
            case 2:
                burstRifleTier1BTN.interactable = false;
                burstRifleTier2BTN.interactable = false;
                burstRifleTier4BTN.interactable = false;
                burstRifleTier5BTN.interactable = false;
                burstRifleTier3BTN.interactable = true;
                break;
            case 3:
                burstRifleTier1BTN.interactable = false;
                burstRifleTier2BTN.interactable = false;
                burstRifleTier3BTN.interactable = false;
                burstRifleTier5BTN.interactable = false;
                burstRifleTier4BTN.interactable = true;
                break;
            case 4:
                burstRifleTier1BTN.interactable = false;
                burstRifleTier2BTN.interactable = false;
                burstRifleTier3BTN.interactable = false;
                burstRifleTier4BTN.interactable = false;
                burstRifleTier5BTN.interactable = true;
                break;
            case 5:
                burstRifleTier1BTN.interactable = false;
                burstRifleTier2BTN.interactable = false;
                burstRifleTier3BTN.interactable = false;
                burstRifleTier4BTN.interactable = false;
                burstRifleTier5BTN.interactable = false;

                WeaponManager.Instance.isBurstRifleMastered = true;
                break;
        }

        switch(WeaponManager.Instance.shotgunUpgradeTier)
        {
            case 0:
                shotgunTier2BTN.interactable = false;
                shotgunTier3BTN.interactable = false;
                shotgunTier4BTN.interactable = false;
                shotgunTier5BTN.interactable = false;
                shotgunTier1BTN.interactable = true;
                break;
            case 1:
                shotgunTier1BTN.interactable = false;
                shotgunTier3BTN.interactable = false;
                shotgunTier4BTN.interactable = false;
                shotgunTier5BTN.interactable = false;
                shotgunTier2BTN.interactable = true;
                break;
            case 2:
                shotgunTier1BTN.interactable = false;
                shotgunTier2BTN.interactable = false;
                shotgunTier4BTN.interactable = false;
                shotgunTier5BTN.interactable = false;
                shotgunTier3BTN.interactable = true;
                break;
            case 3:
                shotgunTier1BTN.interactable = false;
                shotgunTier2BTN.interactable = false;
                shotgunTier3BTN.interactable = false;
                shotgunTier5BTN.interactable = false;
                shotgunTier4BTN.interactable = true;
                break;
            case 4:
                shotgunTier1BTN.interactable = false;
                shotgunTier2BTN.interactable = false;
                shotgunTier3BTN.interactable = false;
                shotgunTier4BTN.interactable = false;
                shotgunTier5BTN.interactable = true;
                break;
            case 5:
                shotgunTier1BTN.interactable = false;
                shotgunTier2BTN.interactable = false;
                shotgunTier3BTN.interactable = false;
                shotgunTier4BTN.interactable = false;
                shotgunTier5BTN.interactable = false;

                WeaponManager.Instance.isShotgunMastered = true;
                break;
        }
    }

    private void Update()
    {
        scrap1.text = "Scrap = " + GameManager.Instance.playerScrap.ToString();
        scrap2.text = "Scrap = " + GameManager.Instance.playerScrap.ToString();
        scrap3.text = "Scrap = " + GameManager.Instance.playerScrap.ToString();

        if(Input.GetKeyDown("e")) //For testing
        {
            WeaponManager.Instance.pistolUpgradeTier = 0;
            WeaponManager.Instance.burstRifleUpgradeTier = 0;
            WeaponManager.Instance.shotgunUpgradeTier = 0;

            WeaponManager.Instance.pistolDamage = 8;
            WeaponManager.Instance.burstRifleDamage = 10;
            WeaponManager.Instance.shotgunDamage = 20;

            WeaponManager.Instance.pistolClip = 8;
            WeaponManager.Instance.burstRifleClip = 15;
            WeaponManager.Instance.shotgunClip = 6;

            WeaponManager.Instance.pistolReserve = 68;
            WeaponManager.Instance.burstRifleReserve = 102;
            WeaponManager.Instance.shotgunReserve = 90;

            WeaponManager.Instance.isPistolMastered = false;
            WeaponManager.Instance.isBurstRifleMastered = false;
            WeaponManager.Instance.isShotgunMastered = false;

            pistolTier2BTN.interactable = false;
            pistolTier3BTN.interactable = false;
            pistolTier4BTN.interactable = false;
            pistolTier5BTN.interactable = false;
            pistolTier1BTN.interactable = true;

            burstRifleTier2BTN.interactable = false;
            burstRifleTier3BTN.interactable = false;
            burstRifleTier4BTN.interactable = false;
            burstRifleTier5BTN.interactable = false;
            burstRifleTier1BTN.interactable = true;

            shotgunTier2BTN.interactable = false;
            shotgunTier3BTN.interactable = false;
            shotgunTier4BTN.interactable = false;
            shotgunTier5BTN.interactable = false;
            shotgunTier1BTN.interactable = true;
        }
    }

    public void ClosePistol()
    {
        pistolTier1TXT.text = "Tier 1 | 5 Scrap";
        pistolTier2TXT.text = "Tier 2 | 10 Scrap";
        pistolTier3TXT.text = "Tier 3 | 15 Scrap";
        pistolTier4TXT.text = "Tier 4 | 20 Scrap";
        pistolTier5TXT.text = "Tier 5 | 25 Scrap";

        pistolUpgradeScereen.SetActive(false);

        pistolSelect.SetActive(true);
    }

    public void CloseBurstRifle()
    {
        burstRifleTier1TXT.text = "Tier 1 | 5 Scrap";
        burstRifleTier2TXT.text = "Tier 2 | 10 Scrap";
        burstRifleTier3TXT.text = "Tier 3 | 15 Scrap";
        burstRifleTier4TXT.text = "Tier 4 | 20 Scrap";
        burstRifleTier5TXT.text = "Tier 5 | 25 Scrap";

        burstRifleUpgradeScreen.SetActive(false);

        burstRifleSelect.SetActive(true);
    }

    public void CloseShotgun()
    {
        shotgunTier1TXT.text = "Tier 1 | 5 Scrap";
        shotgunTier2TXT.text = "Tier 2 | 10 Scrap";
        shotgunTier3TXT.text = "Tier 3 | 15 Scrap";
        shotgunTier4TXT.text = "Tier 4 | 20 Scrap";
        shotgunTier5TXT.text = "Tier 5 | 25 Scrap";

        shotgunUpgradeScreen.SetActive(false);

        shotgunSelect.SetActive(true);
    }

    public void pistolTier1()
    {
        if(GameManager.Instance.playerScrap >= 5)
        {
            GameManager.Instance.playerScrap -= 5;

            WeaponManager.Instance.pistolDamage += 2;

            WeaponManager.Instance.pistolClip += 2;

            WeaponManager.Instance.pistolReserve += 2;

            WeaponManager.Instance.pistolUpgradeTier = 1;

            pistolTier1BTN.interactable = false;
            pistolTier2BTN.interactable = true;
        }
        else
        {
            pistolTier1TXT.text = "Not enough scrap";
        }
    }

    public void pistolTier2()
    {
        if(GameManager.Instance.playerScrap >= 10)
        {
            GameManager.Instance.playerScrap -= 10;

            WeaponManager.Instance.pistolDamage += 2;

            WeaponManager.Instance.pistolClip += 2;

            WeaponManager.Instance.pistolReserve += 2;

            WeaponManager.Instance.pistolUpgradeTier = 2;

            pistolTier2BTN.interactable = false;
            pistolTier3BTN.interactable = true;
            
        }
        else
        {
            pistolTier2TXT.text = "Not enough scrap";
        }

    }

    public void pistolTier3()
    {
        if(GameManager.Instance.playerScrap >= 15)
        {
            GameManager.Instance.playerScrap -= 15;

            WeaponManager.Instance.pistolDamage += 2;

            WeaponManager.Instance.pistolClip += 2;

            WeaponManager.Instance.pistolReserve += 2;

            WeaponManager.Instance.pistolUpgradeTier = 3;

            pistolTier3BTN.interactable = false;
            pistolTier4BTN.interactable = true;
        }
        else
        {
            pistolTier3TXT.text = "Not enough scrap";
        }

    }

    public void pistolTier4()
    {
        if(GameManager.Instance.playerScrap >= 20)
        {
            GameManager.Instance.playerScrap -= 20;
    
            WeaponManager.Instance.pistolDamage += 2;

            WeaponManager.Instance.pistolClip += 2;

            WeaponManager.Instance.pistolReserve += 2;

            WeaponManager.Instance.pistolUpgradeTier = 4;

            pistolTier4BTN.interactable = false;
            pistolTier5BTN.interactable = true;
        }
        else
        {
            pistolTier4TXT.text = "Not enough scrap";
        }

    }

    public void pistolTier5()
    {
        if(GameManager.Instance.playerScrap >= 25)
        {
            WeaponManager.Instance.isPistolMastered = true;

            GameManager.Instance.playerScrap -= 25;

            WeaponManager.Instance.pistolDamage += 2;

            WeaponManager.Instance.pistolClip += 2;

            WeaponManager.Instance.pistolReserve += 2;

            WeaponManager.Instance.pistolUpgradeTier = 5;

            WeaponManager.Instance.isPistolMastered = true;

            pistolTier5BTN.interactable = false;
        }
        else
        {
            pistolTier5TXT.text = "Not enough scrap";
        }

    }

    public void burstRifleTier1()
    {
        if(GameManager.Instance.playerScrap >= 5)
        {
            GameManager.Instance.playerScrap -= 5;

            WeaponManager.Instance.burstRifleDamage += 2;

            WeaponManager.Instance.burstRifleClip += 3;

            WeaponManager.Instance.burstRifleReserve += 3;

            WeaponManager.Instance.burstRifleUpgradeTier = 1;

            burstRifleTier1BTN.interactable = false;
            burstRifleTier2BTN.interactable = true;
        }
        else
        {
            burstRifleTier1TXT.text = "Not enough scrap";
        }
    }

    public void burstRifleTier2()
    {
        if(GameManager.Instance.playerScrap >= 10)
        {
            GameManager.Instance.playerScrap -= 10;

            WeaponManager.Instance.burstRifleDamage += 2;

            WeaponManager.Instance.burstRifleClip += 3;

            WeaponManager.Instance.burstRifleReserve += 3;

            WeaponManager.Instance.burstRifleUpgradeTier = 2;

            burstRifleTier2BTN.interactable = false;
            burstRifleTier3BTN.interactable = true;
            
        }
        else
        {
            burstRifleTier2TXT.text = "Not enough scrap";
        }

    }

    public void burstRifleTier3()
    {
        if(GameManager.Instance.playerScrap >= 15)
        {
            GameManager.Instance.playerScrap -= 15;

            WeaponManager.Instance.burstRifleDamage += 2;

            WeaponManager.Instance.burstRifleClip += 3;

            WeaponManager.Instance.burstRifleReserve += 3;

            WeaponManager.Instance.burstRifleUpgradeTier = 3;

            burstRifleTier3BTN.interactable = false;
            burstRifleTier4BTN.interactable = true;
        }
        else
        {
            burstRifleTier3TXT.text = "Not enough scrap";
        }

    }

    public void burstRifleTier4()
    {
        if(GameManager.Instance.playerScrap >= 20)
        {
            GameManager.Instance.playerScrap -= 20;
    
            WeaponManager.Instance.burstRifleDamage += 2;

            WeaponManager.Instance.burstRifleClip += 3;

            WeaponManager.Instance.burstRifleReserve += 3;

            WeaponManager.Instance.burstRifleUpgradeTier = 4;

            burstRifleTier4BTN.interactable = false;
            burstRifleTier5BTN.interactable = true;
        }
        else
        {
            burstRifleTier4TXT.text = "Not enough scrap";
        }

    }

    public void burstRifleTier5()
    {
        if(GameManager.Instance.playerScrap >= 25)
        {
            GameManager.Instance.playerScrap -= 25;

            WeaponManager.Instance.isBurstRifleMastered = true;

            WeaponManager.Instance.burstRifleDamage += 2;

            WeaponManager.Instance.burstRifleClip += 3;

            WeaponManager.Instance.burstRifleReserve += 3;

            WeaponManager.Instance.burstRifleUpgradeTier = 5;

            WeaponManager.Instance.isBurstRifleMastered = true;

            burstRifleTier5BTN.interactable = false;
        }
        else
        {
            burstRifleTier5TXT.text = "Not enough scrap";
        }

    }

    public void shotgunTier1()
    {
        if(GameManager.Instance.playerScrap >= 5)
        {
            GameManager.Instance.playerScrap -= 5;

            WeaponManager.Instance.shotgunDamage += 2;

            WeaponManager.Instance.shotgunClip += 6;

            WeaponManager.Instance.shotgunReserve += 6;

            WeaponManager.Instance.shotgunUpgradeTier = 1;

            shotgunTier1BTN.interactable = false;
            shotgunTier2BTN.interactable = true;
        }
        else
        {
            shotgunTier1TXT.text = "Not enough scrap";
        }
    }

    public void shotgunTier2()
    {
        if(GameManager.Instance.playerScrap >= 10)
        {
            GameManager.Instance.playerScrap -= 10;

            WeaponManager.Instance.shotgunDamage += 2;

            WeaponManager.Instance.shotgunClip += 6;

            WeaponManager.Instance.shotgunReserve += 6;

            WeaponManager.Instance.shotgunUpgradeTier = 2;

            shotgunTier2BTN.interactable = false;
            shotgunTier3BTN.interactable = true;
            
        }
        else
        {
            shotgunTier2TXT.text = "Not enough scrap";
        }

    }

    public void shotgunTier3()
    {
        if(GameManager.Instance.playerScrap >= 15)
        {
            GameManager.Instance.playerScrap -= 15;

            WeaponManager.Instance.shotgunDamage += 2;

            WeaponManager.Instance.shotgunClip += 6;

            WeaponManager.Instance.shotgunReserve += 6;

            WeaponManager.Instance.shotgunUpgradeTier = 3;

            shotgunTier3BTN.interactable = false;
            shotgunTier4BTN.interactable = true;
        }
        else
        {
            shotgunTier3TXT.text = "Not enough scrap";
        }

    }

    public void shotgunTier4()
    {
        if(GameManager.Instance.playerScrap >= 20)
        {
            GameManager.Instance.playerScrap -= 20;
    
            WeaponManager.Instance.shotgunDamage += 2;

            WeaponManager.Instance.shotgunClip += 6;

            WeaponManager.Instance.shotgunReserve += 6;

            WeaponManager.Instance.shotgunUpgradeTier = 4;

            shotgunTier4BTN.interactable = false;
            shotgunTier5BTN.interactable = true;
        }
        else
        {
            shotgunTier4TXT.text = "Not enough scrap";
        }

    }

    public void shotgunTier5()
    {
        if(GameManager.Instance.playerScrap >= 25)
        {
            GameManager.Instance.playerScrap -= 25;

            WeaponManager.Instance.shotgunDamage += 2;

            WeaponManager.Instance.shotgunClip += 6;

            WeaponManager.Instance.shotgunReserve += 6;

            WeaponManager.Instance.shotgunUpgradeTier = 5;

            WeaponManager.Instance.isShotgunMastered = true;

            shotgunTier5BTN.interactable = false;
        }
        else
        {
            shotgunTier5TXT.text = "Not enough scrap";
        }

    }
}
