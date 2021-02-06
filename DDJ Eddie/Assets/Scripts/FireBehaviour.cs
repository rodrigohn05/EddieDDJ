using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    float time=4f;
    //public Transform SpawnPoint;
    public GameObject prefab;

    void Update(){
        //SoundManager.PlaySound("flames");
    }

    void OnTriggerEnter2D(Collider2D collider){
        if (collider.gameObject.tag == "Water"){
            time -= Time.deltaTime;
            
            //Debug.Log("tempo "+ time);
            if(time<=0f){
                Destroy(gameObject);
                GameObject enemy = Instantiate(prefab, transform.position, transform.rotation);
                time = 4f;
            }
        }
    }
    
    
}
