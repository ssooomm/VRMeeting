using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonDestroyObject : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
