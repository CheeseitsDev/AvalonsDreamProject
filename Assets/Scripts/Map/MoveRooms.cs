using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRooms : MonoBehaviour
{
    public int roomNum;

    private void Update()
    {
        Open();
    }

    private void Open()
    {
        switch(roomNum)
        {
            case 1:
                if(GameManager.Instance.isRoom1Complete)
                {
                    Destroy(gameObject);
                }
                break;
            case 2:
                if(GameManager.Instance.isRoom2Complete)
                {
                    Destroy(gameObject);
                }
                break;
            case 3:
                if(GameManager.Instance.isRoom3Complete)
                {
                    Destroy(gameObject);
                }
                break;
            case 4:
                if(GameManager.Instance.isRoom4Complete)
                {
                    Destroy(gameObject);
                }
                break;
            case 5:
                if(GameManager.Instance.isRoom5Complete)
                {
                    Destroy(gameObject);
                }
                break;
        }
    }
}
