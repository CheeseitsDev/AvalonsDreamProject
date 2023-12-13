using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Alessandro Napoli

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingMenu;
    public GameObject creditScene;

    private void Start()
    {
        settingMenu.SetActive(false);
        creditScene.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Cutscene1");
    }
    public void Settings()
    {
        mainMenu.SetActive(false);
        settingMenu.SetActive(true);    
    }
    public void Back()
    {
        settingMenu.SetActive(false);
        creditScene.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void Credits()
    {
        mainMenu.SetActive(false);
        creditScene.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
