using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class Scrap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            GameManager.Instance.playerScrap ++;

            Destroy(gameObject);
        }
    }
}
