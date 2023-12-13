using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

//Ethan Hoare st20271423

public class BossDash : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform target;
    private Vector2 moveDiretction;
    private float timer;

    private void Awake()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
    }

    private void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    void Update()
    {
       if(target)
        {
            Vector3 direction = (target.position -transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDiretction = direction;
            timer += Time.deltaTime;
            if (timer > 5)
            {
                GameManager.Instance.bossSpeed = 5;
            }
        }
    }

    private void FixedUpdate()
    {
        if(target)
        {
            rb.velocity = new Vector2(moveDiretction.x, moveDiretction.y) * GameManager.Instance.bossSpeed;
        }
    }
    
    public void Speed()
    {
        timer = 100;

        if(timer == 100)
        {
            GameManager.Instance.bossSpeed = 10;
            
        }
    }
}
