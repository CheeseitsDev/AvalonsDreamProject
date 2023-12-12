using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman st20266734

public class DontDestory : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
