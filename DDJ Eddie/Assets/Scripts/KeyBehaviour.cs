using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBehaviour : MonoBehaviour
{
    
    public static int key1;
    public static int key2;
    public static int key3;

    void Update(){
        key1 = PlayerMovement.key1;
        key2 = PlayerMovement.key2;
        key3 = PlayerMovement.key3;
        if(key1 == 1 && gameObject.tag == "Key1"){
            Destroy(gameObject);
        }
        
        if(key2 == 1 && gameObject.tag == "Key2"){
            Destroy(gameObject);
        }
        
        if(key3 == 1 && gameObject.tag == "Key3"){
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }
    
}
