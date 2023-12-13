using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable] 

//Ethan Hoare

public class CoolDown : MonoBehaviour
{
    private float coolDownUp;

    public bool coolDownEnabled => Time.time < coolDownUp;
    public void StartCoolDown() => coolDownUp = Time.time + WeaponManager.Instance.coolDown;
}
