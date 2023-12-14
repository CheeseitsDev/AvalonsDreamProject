using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class GameManager : MonoBehaviour
{
    [Header("Player Attributes")] //Creates a header in inspector
    public int playerScrap = 0;
    public int playerMaxHealth = 100;
    public int playerCurrentHealth = 100;
    public int playerMaxShieldCharges = 0;
    public int playerCurrentShieldCharge = 0;
    public int playerHealthUpgradeTier;
    public int playerShieldUpgradeTier;
    public float playerSpeed = 5f;
    public float playerRegenSpeed = 10f;
    public float playerShieldRegenSpeed = 60f;

    [Header("Enemy Attributes")]
    public int enemyHealth = 20;
    public int enemyDamage = 5;
    public float enemySpeed = 3.5f;

    [Header("Boss Attributes")]
    public int maxBossHealth = 100;
    public int bossHealth = 100;
    public int bossDamage = 15;
    public int bossForce = 20;
    public int bossSpeed = 5;


    [Header("Game Attributes")]
    public bool isPaused = false;
    public bool isRoom1Complete = false;
    public bool isRoom2Complete = false;
    public bool isRoom3Complete = false;
    public bool isRoom4Complete = false;
    public bool isRoom5Complete = false;

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
