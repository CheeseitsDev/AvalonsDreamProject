using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Ashley Gentleman

public class PauseMenu : MonoBehaviour
{
    public GameObject player;
    public GameObject pauseMenu;
    public GameObject settingsMenu;

    private void Start()
    {
        GameManager.Instance.isPaused = false;

        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);
        player.SetActive(true);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!GameManager.Instance.isPaused)
            {
                Pause();
            }
            else
            {
                UnPause();
            }
        }
    }

    public void Settings()
    {
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }

    private void Pause()
    {
        GameManager.Instance.isPaused = true;

        Time.timeScale = 0;

        player.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void UnPause()
    {
        GameManager.Instance.isPaused = false;

        Time.timeScale = 1;

        settingsMenu.SetActive(false);
        pauseMenu.SetActive(false);
        player.SetActive(true);
    }

    public void MainMenu()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene("MainMenu");
    }
}
