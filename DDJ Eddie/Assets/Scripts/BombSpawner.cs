using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    public float time = 20f;
    public static int rand;

    void Update()
    {
        time -= Time.deltaTime;
        if(time<=0f){
            rand = Random.Range(1,6);
            time = 20f;
        }
    }
}
