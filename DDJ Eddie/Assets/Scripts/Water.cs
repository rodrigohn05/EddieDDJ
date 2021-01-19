﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    
    public float lifeTime = 2f;

    void Update(){
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0){
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        Destroy(gameObject);
        if(collision.gameObject.tag == "Enemy"){
            GetComponent<Rigidbody2D>().AddForce(transform.right * 1);
        }
    }
}
