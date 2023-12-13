using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class followCursorForGun : MonoBehaviour
{
    public Vector2 pointerPos {get; set;}

    private void Update() //Moves gun to look at cursor
    {
        Vector2 direction = (pointerPos - (Vector2)transform.position).normalized;

        transform.right = direction;
    }
}
