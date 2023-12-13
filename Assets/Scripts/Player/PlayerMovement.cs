using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if(Input.GetKey("w")) //Moves player up
        {
            rb.AddForce(transform.up * GameManager.Instance.playerSpeed);
        }
        if(Input.GetKey("s")) //Moves player down
        {
            rb.AddForce(-transform.up * GameManager.Instance.playerSpeed);
        }
        if(Input.GetKey("d")) //Moves player right
        {
            rb.AddForce(transform.right * GameManager.Instance.playerSpeed);
        }
        if(Input.GetKey("a")) //Moves player left
        {
            rb.AddForce(-transform.right * GameManager.Instance.playerSpeed);
        }
    }
}
