using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Adam Thomas

public class ChaseIsOn : MonoBehaviour
{
    public Rigidbody2D rb;

    private Transform target;
    private Vector2 moveDiretction;

    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 direction = (target.position -transform.position).normalized;
        float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        rb.rotation = angle;
        moveDiretction = direction;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDiretction.x, moveDiretction.y) * GameManager.Instance.enemySpeed;
    }
}
