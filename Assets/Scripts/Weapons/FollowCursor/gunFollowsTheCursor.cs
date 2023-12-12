using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman st20266734

public class gunFollowsTheCursor : MonoBehaviour
{
    private followCursorForGun gunParent;
    private Vector2 mouseCursorPos;

    private void Start()
    {
        gunParent = GetComponentInChildren<followCursorForGun>(); //Finds component in hierarchy
    }

    private void Update()
    {
        mouseCursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Gets the position of the mouse

        gunParent.pointerPos = mouseCursorPos; //Tells the other script to set pointerPos to the mouses positon
    }
}
