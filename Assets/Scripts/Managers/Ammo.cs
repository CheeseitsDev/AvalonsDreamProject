using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    private void Start()
    {
        switch(WeaponManager.Instance.pistolUpgradeTier)
        {
            case 0:
                WeaponManager.Instance.pistolClip = 8;
                WeaponManager.Instance.pistolReserve = 68;
                break;
            case 1:
                WeaponManager.Instance.pistolClip = 10;
                WeaponManager.Instance.pistolReserve = 70;
                break;
            case 2:
                WeaponManager.Instance.pistolClip = 12;
                WeaponManager.Instance.pistolReserve = 72;
                break;
            case 3:
                WeaponManager.Instance.pistolClip = 14;
                WeaponManager.Instance.pistolReserve = 74;
                break;
            case 4:
                WeaponManager.Instance.pistolClip = 16;
                WeaponManager.Instance.pistolReserve = 76;
                break;
            case 5:
                WeaponManager.Instance.pistolClip = 18;
                WeaponManager.Instance.pistolReserve = 78;
                break;
        }

        switch(WeaponManager.Instance.burstRifleUpgradeTier)
        {
            case 0:
                WeaponManager.Instance.burstRifleClip = 15;
                WeaponManager.Instance.burstRifleReserve = 102;
                break;
            case 1:
                WeaponManager.Instance.burstRifleClip = 18;
                WeaponManager.Instance.burstRifleReserve = 105;
                break;
            case 2:
                WeaponManager.Instance.burstRifleClip = 21;
                WeaponManager.Instance.burstRifleReserve = 108;
                break;
            case 3:
                WeaponManager.Instance.burstRifleClip = 24;
                WeaponManager.Instance.burstRifleReserve = 111;
                break;
            case 4:
                WeaponManager.Instance.burstRifleClip = 27;
                WeaponManager.Instance.burstRifleReserve = 114;
                break;
            case 5:
                WeaponManager.Instance.burstRifleClip = 30;
                WeaponManager.Instance.burstRifleReserve = 117;
                break;
        }

        switch(WeaponManager.Instance.shotgunUpgradeTier)
        {
            case 0:
                WeaponManager.Instance.shotgunClip = 6;
                WeaponManager.Instance.shotgunReserve = 90;
                break;
            case 1:
                WeaponManager.Instance.shotgunClip = 12;
                WeaponManager.Instance.shotgunReserve = 96;
                break;
            case 2:
                WeaponManager.Instance.shotgunClip = 18;
                WeaponManager.Instance.shotgunReserve = 112;
                break;
            case 3:
                WeaponManager.Instance.shotgunClip = 24;
                WeaponManager.Instance.shotgunReserve = 118;
                break;
            case 4:
                WeaponManager.Instance.shotgunClip = 30;
                WeaponManager.Instance.shotgunReserve = 124;
                break;
            case 5:
                WeaponManager.Instance.shotgunClip = 36;
                WeaponManager.Instance.shotgunReserve = 130;
                break;
        }
    }
}
