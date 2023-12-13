using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//Ethan Hoare

public class BossDash2 : MonoBehaviour
{
    private float timer;
    public BossDash dash;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        dash.Speed();
    }
}
