using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float lifeTime = 3f;

    void Update(){
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0){
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        Destroy(gameObject);
        
    }
}
