using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextKey : MonoBehaviour
{
    public static int keys=0;
    public static int deaths=0;

    public int kd;
    
    Text scorekey;
    Text scoredeath;

    void Start()
    {
        scorekey = GetComponent<Text>();
        scoredeath = GetComponent<Text>();

    }

    void Update()
    {
        if(DeathScreen.restart==1){
            deaths=0;
        }
        if(kd==0){
            scorekey.text = "x " + keys;
        }
        else if(kd==1){
            scoredeath.text = deaths + " x"  ;
        }
        else{
            scoredeath.text = "x " + deaths;
        }
    }
}
