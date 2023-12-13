using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Alessandro Napoli

public class StartUp : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(startTime());
    }
    private IEnumerator startTime()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("MainMenu");
    }
}
