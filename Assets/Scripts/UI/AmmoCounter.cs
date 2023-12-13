using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Ashley Gentleman

public class AmmoCounter : MonoBehaviour
{
    public TMP_Text gunName;
    public TMP_Text gunClip;
    public TMP_Text gunReserve;

    private void Start()
    {
        if(WeaponManager.Instance.isPistolSelected)
        {
            gunName.text = "Pistol";
        }
        else if(WeaponManager.Instance.isBurstRifleSelected)
        {
            gunName.text = "Burst Rifle";
        }
        else
        {
            gunName.text = "Shotgun";
        }
    }

    private void Update()
    {
        if(WeaponManager.Instance.isPistolSelected)
        {
            gunClip.text = WeaponManager.Instance.pistolCurrentClip.ToString();
            gunReserve.text = WeaponManager.Instance.pistolReserve.ToString();
        }
        else if(WeaponManager.Instance.isBurstRifleSelected)
        {
            gunClip.text = WeaponManager.Instance.burstRifleCurrentClip.ToString();
            gunReserve.text = WeaponManager.Instance.burstRifleReserve.ToString();
        }
        else
        {
            gunClip.text = WeaponManager.Instance.shotgunCurrentClip.ToString();
            gunReserve.text = WeaponManager.Instance.shotgunReserve.ToString();
        }
    }
}
