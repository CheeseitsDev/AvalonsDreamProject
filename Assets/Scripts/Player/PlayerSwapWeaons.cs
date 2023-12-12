using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman st20266734

public class PlayerSwapWeaons : MonoBehaviour
{
    public GameObject pistol;
    public GameObject burstRifle;
    public GameObject shotgun;

    private void Awake()
    {
        if(WeaponManager.Instance.isPistolSelected)
        {
            burstRifle.SetActive(false);
            shotgun.SetActive(false);
            pistol.SetActive(true);
        }
        else if(WeaponManager.Instance.isBurstRifleSelected)
        {
            pistol.SetActive(false);
            shotgun.SetActive(false);
            burstRifle.SetActive(true);
        }
        else
        {
            pistol.SetActive(false);
            burstRifle.SetActive(false);
            shotgun.SetActive(true);
        }
    }
}
