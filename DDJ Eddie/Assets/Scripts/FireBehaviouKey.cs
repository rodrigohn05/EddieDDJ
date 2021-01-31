using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviouKey : MonoBehaviour
{
    float time=4f;
    public Transform SpawnPoint;
    public GameObject prefab;

    public GameObject keyPrefab;
    void Update(){
        
    }

    void OnTriggerEnter2D(Collider2D collider){
        if (collider.gameObject.tag == "Water"){
            time -= Time.deltaTime;
            
            //Debug.Log("tempo "+ time);
            if(time<=0f){
                Destroy(gameObject);
                GameObject enemy = Instantiate(prefab, SpawnPoint.position, SpawnPoint.rotation);
                GameObject key = Instantiate(keyPrefab, SpawnPoint.position, SpawnPoint.rotation);
                time = 4f;
            }
        }
    }
}
