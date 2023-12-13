using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

//Ethan Hoare st20271423

public class Emp: MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject empPrefab;
    [SerializeField] private CoolDown coolDown;

    private void Update()
    {
        if(Input.GetKeyDown("q")) 
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if(coolDown.coolDownEnabled) return;
        GameObject bullet = Instantiate(empPrefab, shootingPoint.position, shootingPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
      
        coolDown.StartCoolDown();
    }
}
