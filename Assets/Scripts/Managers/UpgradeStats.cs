using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman st20266734

public class UpgradeStats : MonoBehaviour
{
    private string scrapKey = "Scrap";
    private string upgradePistolKey = "Pistol Upgrade";
    private string upgradeBurstRifleKey = "BurstRifle Upgrade";
    private string upgradeShotgunKey = "Shotgun Upgrade";
    private string upgradeHealthKey = "Health Upgrade";
    private string upgradeShieldKey = "Shield Upgrade";
    private string pistolDamageKey = "Pistol Damage";
    private string burstRifleDamageKey = "Burst Rifle Damage";
    private string shotgunDamageKey = "Shotgun Damage";
    private string healthKey = "Health";
    private string shieldKey = "Shield";
    private string pistolClipKey = "Pistol Clip";
    private string burstRifleClipKey = "Burst Rifle Clip";
    private string shotgunClipKey = "Shotgun Clip";
    private string healthRegenKey = "Health Regen";
    private string shieldRegenKey = "Shield Regen";
    private string pistolReserveKey = "Pistol Reserve";
    private string burstRifleReserveKey = "Burst Rifle Reserve";
    private string shotgunReserveKey = "Shotgun Reserve";
    private int scrap;
    private int pistolUpgrade;
    private int burstRifleUpgrade;
    private int shotgunUpgrade;
    private int healthUpgrade;
    private int shieldUpgrade;
    private int pistolDamage;
    private int burstRifleDamage;
    private int shotgunDamage;
    private int healthNumber;
    private int shieldNumber;
    private int pistolClip;
    private int burstRifleClip;
    private int shotgunClip;
    private float regenSpeed;
    private float shieldRegenSpeed;
    private int pistolReserve;
    private int burstRifleReserve;
    private int shotgunReserve;

    private void Awake()
    {
        GameManager.Instance.playerScrap = PlayerPrefs.GetInt(scrapKey, 0);

        WeaponManager.Instance.pistolUpgradeTier = PlayerPrefs.GetInt(upgradePistolKey, 0);
        WeaponManager.Instance.burstRifleUpgradeTier = PlayerPrefs.GetInt(upgradeBurstRifleKey, 0);
        WeaponManager.Instance.shotgunUpgradeTier = PlayerPrefs.GetInt(upgradeShotgunKey, 0);
        GameManager.Instance.playerHealthUpgradeTier = PlayerPrefs.GetInt(upgradeHealthKey, 0);
        GameManager.Instance.playerShieldUpgradeTier = PlayerPrefs.GetInt(upgradeShieldKey, 0);

        WeaponManager.Instance.pistolDamage = PlayerPrefs.GetInt(pistolDamageKey, 8);
        WeaponManager.Instance.burstRifleDamage = PlayerPrefs.GetInt(burstRifleDamageKey, 10);
        WeaponManager.Instance.shotgunDamage = PlayerPrefs.GetInt(shotgunDamageKey, 20);
        GameManager.Instance.playerMaxHealth = PlayerPrefs.GetInt(healthKey, 100);
        GameManager.Instance.playerMaxShieldCharges = PlayerPrefs.GetInt(shieldKey, 0);

        WeaponManager.Instance.pistolClip = PlayerPrefs.GetInt(pistolClipKey, 8);
        WeaponManager.Instance.burstRifleClip = PlayerPrefs.GetInt(burstRifleClipKey, 15);
        WeaponManager.Instance.shotgunClip = PlayerPrefs.GetInt(shotgunClipKey, 6);
        GameManager.Instance.playerRegenSpeed = PlayerPrefs.GetFloat(healthRegenKey, 10);
        GameManager.Instance.playerShieldRegenSpeed = PlayerPrefs.GetFloat(shieldRegenKey, 60);

        WeaponManager.Instance.pistolReserve = PlayerPrefs.GetInt(pistolReserveKey, 68);
        WeaponManager.Instance.burstRifleReserve = PlayerPrefs.GetInt(burstRifleReserveKey, 10);
        WeaponManager.Instance.shotgunReserve = PlayerPrefs.GetInt(shotgunReserveKey, 90);

    }

    private void Update()
    {
        Save();
    }

    private void Save()
    {
        scrap = GameManager.Instance.playerScrap;

        pistolUpgrade = WeaponManager.Instance.pistolUpgradeTier;
        burstRifleUpgrade = WeaponManager.Instance.burstRifleUpgradeTier;
        shotgunUpgrade = WeaponManager.Instance.shotgunUpgradeTier;
        healthUpgrade = GameManager.Instance.playerHealthUpgradeTier;
        shieldUpgrade = GameManager.Instance.playerShieldUpgradeTier;
        
        pistolDamage = WeaponManager.Instance.pistolDamage;
        burstRifleDamage = WeaponManager.Instance.burstRifleDamage;
        shotgunDamage = WeaponManager.Instance.shotgunDamage;
        healthNumber = GameManager.Instance.playerMaxHealth;
        shieldNumber = GameManager.Instance.playerMaxShieldCharges;

        pistolClip = WeaponManager.Instance.pistolClip;
        burstRifleClip = WeaponManager.Instance.burstRifleClip;
        shotgunClip = WeaponManager.Instance.shotgunClip;
        regenSpeed = GameManager.Instance.playerRegenSpeed;
        shieldRegenSpeed = GameManager.Instance.playerShieldRegenSpeed;

        pistolReserve = WeaponManager.Instance.pistolReserve;
        burstRifleReserve = WeaponManager.Instance.burstRifleReserve;
        shotgunReserve = WeaponManager.Instance.shotgunReserve;

        PlayerPrefs.SetInt(scrapKey, scrap);

        PlayerPrefs.SetInt(upgradePistolKey, pistolUpgrade);
        PlayerPrefs.SetInt(upgradeBurstRifleKey, burstRifleUpgrade);
        PlayerPrefs.SetInt(upgradeShotgunKey, shotgunUpgrade);
        PlayerPrefs.SetInt(upgradeHealthKey, healthUpgrade);
        PlayerPrefs.SetInt(upgradeShieldKey, shieldUpgrade);

        PlayerPrefs.SetInt(pistolDamageKey, pistolDamage);
        PlayerPrefs.SetInt(burstRifleDamageKey, burstRifleDamage);
        PlayerPrefs.SetInt(shotgunDamageKey, shotgunDamage);
        PlayerPrefs.SetInt(healthKey, healthNumber);
        PlayerPrefs.SetInt(shieldKey, shieldNumber);

        PlayerPrefs.SetInt(pistolClipKey, pistolClip);
        PlayerPrefs.SetInt(burstRifleClipKey, burstRifleClip);
        PlayerPrefs.SetInt(shotgunClipKey, shotgunClip);
        PlayerPrefs.SetFloat(healthRegenKey, regenSpeed);
        PlayerPrefs.SetFloat(shieldRegenKey, shieldRegenSpeed);

        PlayerPrefs.SetInt(pistolReserveKey, pistolReserve);
        PlayerPrefs.SetInt(burstRifleReserveKey, burstRifleReserve);
        PlayerPrefs.SetInt(shotgunReserveKey, shotgunReserve);

        PlayerPrefs.Save();
    }
}
