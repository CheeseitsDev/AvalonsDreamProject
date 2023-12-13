using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Alessandro Napoli

public class GameOver : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
    public void TryAgain()
    {
        SceneManager.LoadScene("WeaponSelect");
    }
}