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
    private string pistolDamageKey = "Pistol Damage";
    private string burstRifleDamageKey = "Burst Rifle Damage";
    private string shotgunDamageKey = "Shotgun Damage";
    private string pistolClipKey = "Pistol Clip";
    private string burstRifleClipKey = "Burst Rifle Clip";
    private string shotgunClipKey = "Shotgun Clip";
    private string pistolReserveKey = "Pistol Reserve";
    private string burstRifleReserveKey = "Burst Rifle Reserve";
    private string shotgunReserveKey = "Shotgun Reserve";
    private int scrap;
    private int pistolUpgrade;
    private int burstRifleUpgrade;
    private int shotgunUpgrade;
    private int pistolDamage;
    private int burstRifleDamage;
    private int shotgunDamage;
    private int pistolClip;
    private int burstRifleClip;
    private int shotgunClip;
    private int pistolReserve;
    private int burstRifleReserve;
    private int shotgunReserve;

    private void Start()
    {
        GameManager.Instance.playerScrap = PlayerPrefs.GetInt(scrapKey, 0);

        WeaponManager.Instance.pistolUpgradeTier = PlayerPrefs.GetInt(upgradePistolKey, 0);
        WeaponManager.Instance.burstRifleUpgradeTier = PlayerPrefs.GetInt(upgradeBurstRifleKey, 0);
        WeaponManager.Instance.shotgunUpgradeTier = PlayerPrefs.GetInt(upgradeShotgunKey, 0);

        WeaponManager.Instance.pistolDamage = PlayerPrefs.GetInt(pistolDamageKey, 8);
        WeaponManager.Instance.burstRifleDamage = PlayerPrefs.GetInt(burstRifleDamageKey, 10);
        WeaponManager.Instance.shotgunDamage = PlayerPrefs.GetInt(shotgunDamageKey, 20);

        WeaponManager.Instance.pistolClip = PlayerPrefs.GetInt(pistolClipKey, 8);
        WeaponManager.Instance.burstRifleClip = PlayerPrefs.GetInt(burstRifleClipKey, 15);
        WeaponManager.Instance.shotgunClip = PlayerPrefs.GetInt(shotgunClipKey, 6);

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
        
        pistolDamage = WeaponManager.Instance.pistolDamage;
        burstRifleDamage = WeaponManager.Instance.burstRifleDamage;
        shotgunDamage = WeaponManager.Instance.shotgunDamage;

        pistolClip = WeaponManager.Instance.pistolClip;
        burstRifleClip = WeaponManager.Instance.burstRifleClip;
        shotgunClip = WeaponManager.Instance.shotgunClip;

        pistolReserve = WeaponManager.Instance.pistolReserve;
        burstRifleReserve = WeaponManager.Instance.burstRifleReserve;
        shotgunReserve = WeaponManager.Instance.shotgunReserve;

        PlayerPrefs.SetInt(scrapKey, scrap);

        PlayerPrefs.SetInt(upgradePistolKey, pistolUpgrade);
        PlayerPrefs.SetInt(upgradeBurstRifleKey, burstRifleUpgrade);
        PlayerPrefs.SetInt(upgradeShotgunKey, shotgunUpgrade);

        PlayerPrefs.SetInt(pistolDamageKey, pistolDamage);
        PlayerPrefs.SetInt(burstRifleDamageKey, burstRifleDamage);
        PlayerPrefs.SetInt(shotgunDamageKey, shotgunDamage);

        PlayerPrefs.SetInt(pistolClipKey, pistolClip);
        PlayerPrefs.SetInt(burstRifleClipKey, burstRifleClip);
        PlayerPrefs.SetInt(shotgunClipKey, shotgunClip);

        PlayerPrefs.SetInt(pistolReserveKey, pistolReserve);
        PlayerPrefs.SetInt(burstRifleReserveKey, burstRifleReserve);
        PlayerPrefs.SetInt(shotgunReserveKey, shotgunReserve);

        PlayerPrefs.Save();
    }
}
