using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepWaterLevel : MonoBehaviour
{
    void Update()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
