using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBehaviour : MonoBehaviour
{
    public float time = 15f;

    void Update()
    {
        time -= Time.deltaTime;
        if(time<=0f){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Boss" || collision.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }
}
