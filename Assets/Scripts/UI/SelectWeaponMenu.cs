using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Ashley Gentleman

public class SelectWeaponMenu : MonoBehaviour
{
    public GameObject pistolSelect;
    public GameObject burstRifleSelect;
    public GameObject shotgunSelect;
    public GameObject pistolUpgrade;
    public GameObject burstRifleUpgrade;
    public GameObject shotgunUpgrade;
    private GameObject musicPlayer;

    private void Start()
    {
        pistolSelect.SetActive(true);
        burstRifleSelect.SetActive(false);
        shotgunSelect.SetActive(false);
        pistolUpgrade.SetActive(false);
        burstRifleUpgrade.SetActive(false);
        shotgunUpgrade.SetActive(false);

        musicPlayer = GameObject.Find("BackgroundMusic");
    }

    public void SelectPistol()
    {
        WeaponManager.Instance.isBurstRifleSelected = false;
        WeaponManager.Instance.isShotgunSelected = false;
        WeaponManager.Instance.isPistolSelected = true;

        Destroy(musicPlayer);

        SceneManager.LoadScene("Game");
    }

    public void SelectBurstRifle()
    {
        WeaponManager.Instance.isPistolSelected = false;
        WeaponManager.Instance.isShotgunSelected = false;
        WeaponManager.Instance.isBurstRifleSelected = true;

        Destroy(musicPlayer);

        SceneManager.LoadScene("Game");
    }
    
    public void SelectShotgun()
    {
        WeaponManager.Instance.isPistolSelected = false;
        WeaponManager.Instance.isBurstRifleSelected = false;
        WeaponManager.Instance.isShotgunSelected = true;

        Destroy(musicPlayer);

        SceneManager.LoadScene("Game");
    }

    public void UpgradePistol()
    {
        pistolSelect.SetActive(false);
        pistolUpgrade.SetActive(true);
    }

    public void UpgradeBurstRifle()
    {
        pistolSelect.SetActive(false);
        burstRifleUpgrade.SetActive(true);
    }

    public void UpgradeShotgun()
    {
        pistolSelect.SetActive(false);
        shotgunUpgrade.SetActive(true);
    }

    public void PistolNextWeapon()
    {
        pistolSelect.SetActive(false);
        shotgunSelect.SetActive(false);
        burstRifleSelect.SetActive(true);
    }

    public void BurstRifleNextWeapon()
    {
        pistolSelect.SetActive(false);
        burstRifleSelect.SetActive(false);
        shotgunSelect.SetActive(true);
    }

    public void BurstRifleLastWeapon()
    {
        burstRifleSelect.SetActive(false);
        shotgunSelect.SetActive(false);
        pistolSelect.SetActive(true);
    }

    public void ShotgunLastWeapon()
    {
        shotgunSelect.SetActive(false);
        pistolSelect.SetActive(false);
        burstRifleSelect.SetActive(true);
    }
}
