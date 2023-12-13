using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman st20266734

public class WeaponManager : MonoBehaviour
{
    [Header("Emp")]
    public int coolDown = 5;

    [Header("Bullet")] //Creates a header in inspector
    public int bulletSpeed = 8;

    [Header("Pistol")] //Creates a header in inspector
    public int pistolDamage = 8;
    public int pistolCurrentClip = 0;
    public int pistolClip = 8;
    public int pistolReserve = 68;
    public int pistolUpgradeTier;
    public float pistolShootDelay = 0.5f;
    public bool isPistolSelected = false;
    public bool isPistolMastered = false;

    [Header("BurstRifle")]
    public int burstRifleDamage = 10;
    public int burstRifleCurrentClip;
    public int burstRifleClip = 15;
    public int burstRifleReserve = 102;
    public int burstRifleUpgradeTier;
    public float burstRifleShootDelay = 0.5f;
    public bool isBurstRifleSelected = false;
    public bool isBurstRifleMastered = false;

    [Header("Shotgun")]
    public int shotgunDamage = 20;
    public int shotgunCurrentClip;
    public int shotgunClip = 6;
    public int shotgunReserve = 90;
    public int shotgunUpgradeTier;
    public float shotgunShootDelay = 0.8f;
    public bool isShotgunSelected = false;
    public bool isShotgunMastered = false;

    private void Awake() //This is called before Start function
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public static WeaponManager Instance; //Allows variables to be called in other scripts
}
