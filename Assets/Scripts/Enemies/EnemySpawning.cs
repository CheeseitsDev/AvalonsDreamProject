using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class EnemySpawning : MonoBehaviour
{
    public GameObject enemies;
    public int numOfEnemies;
    public int roomNum;

    private void Start()
    {
        enemies.SetActive(false);
    }

    private void Update()
    {
        DecreaseNumOFEnemies();
    }

    private void DecreaseNumOFEnemies()
    {
        numOfEnemies = enemies.transform.childCount;

        if(numOfEnemies <= 0)
        {
            switch(roomNum)
            {
                case 1:
                    GameManager.Instance.isRoom1Complete = true;
                    break;
                case 2:
                    GameManager.Instance.isRoom2Complete = true;
                    break;
                case 3:
                    GameManager.Instance.isRoom3Complete = true;
                    break;
                case 4:
                    GameManager.Instance.isRoom4Complete = true;
                    break;
                case 5:
                    GameManager.Instance.isRoom5Complete = true;
                    break;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collsion)
    {
        if(collsion.tag == "Player")
        {
            enemies.SetActive(true);
        }
    }
}
