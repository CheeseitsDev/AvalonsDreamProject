using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman st20266734

public class GameManager : MonoBehaviour
{
    [Header("Player Attributes")] //Creates a header in inspector
    public int playerScrap = 0;
    public int playerMaxHealth = 100;
    public int playerCurrentHealth = 100;
    public float playerSpeed = 5f;

    [Header("Enemy Attributes")]
    public int enemyHealth = 100;
    public int enemyDamage = 10;
    public float enemySpeed = 3.5f;


    [Header("Game Attributes")]
    public bool isPaused = false;

    private void Awake() //This is called before Start function
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public static GameManager Instance; //Allows variables to be called in other scripts
}
