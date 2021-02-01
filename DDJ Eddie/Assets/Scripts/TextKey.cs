using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextKey : MonoBehaviour
{
    public static int keys=0;
    Text scorekey;
    void Start()
    {
        scorekey = GetComponent<Text>();
    }

    void Update()
    {
        scorekey.text = "x " + keys;
    }
}
