using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman st20266734

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start()
    {
        StartCoroutine(DestroyBullet()); //Starts timer
    }

    private void Update()
    {
        BulletBehaviour();
    }

    private void BulletBehaviour()
    {
        rb.AddForce(transform.up * WeaponManager.Instance.bulletSpeed); //Moves bullet
    }

    private IEnumerator DestroyBullet() //Destroys bullet after 5 seconds
    {
        yield return new WaitForSeconds(5f); 

        Destroy(gameObject);
    }
}
