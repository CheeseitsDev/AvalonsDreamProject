using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ashley Gentleman

public class DontDestory : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
