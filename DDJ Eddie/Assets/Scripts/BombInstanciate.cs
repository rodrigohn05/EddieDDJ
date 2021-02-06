using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInstanciate : MonoBehaviour
{   
    public int spawn=0;
    public GameObject prefab;
    public static int rand;
    public float time=20f;
    void Update()
    {
        time -= Time.deltaTime;
        rand = BombSpawner.rand;
        Debug.Log("spawn " + spawn+", rand "+ rand);
        if(spawn == rand && time <=0f){
            GameObject bomb = Instantiate(prefab, transform.position, transform.rotation);
            time = 20f;
        }
    }
}
