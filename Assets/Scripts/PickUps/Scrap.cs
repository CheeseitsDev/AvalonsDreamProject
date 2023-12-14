using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class Scrap : MonoBehaviour
{
    public void IncreaseScrap(int scrapNum)
    {
        GameManager.Instance.playerScrap += scrapNum;
    }
}
