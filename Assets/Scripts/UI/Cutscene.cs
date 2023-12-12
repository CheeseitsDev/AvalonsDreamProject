using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Ashley Gentleman st20266734

public class Cutscene : MonoBehaviour
{
    public GameObject continueButton;

    private bool canContinue = false;

    private void Start()
    {
        continueButton.SetActive(false);

        StartCoroutine(showContinueButton());
    }

    private void Update()
    {
        if(canContinue)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("WeaponSelect");
            }
        }
    }

    private IEnumerator showContinueButton()
    {
        yield return new WaitForSeconds(3f);

        continueButton.SetActive(true);

        canContinue = true;
    }
}
