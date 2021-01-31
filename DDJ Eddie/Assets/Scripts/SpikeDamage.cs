using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public float time=1f;
    public int maxHealth;
    private int currentHealth;
    public HealthBar hb;

    void Start(){
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);
    }
    void Update(){
        time -= Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "Spikes" ){
            takeDamage();
           // time = 1f;
            if (currentHealth<=0){
                Destroy(gameObject);
                
            }
        }
    }
    
    void OnTriggerEnter2D(Collider2D collider){
        if (collider.gameObject.tag=="Fire"){
            takeDamage();
            //time=1f;
            if (currentHealth<=0){
                Destroy(gameObject);
                
            }
        }
    }

    void takeDamage(){
        currentHealth -= 1;
        hb.SetHealth(currentHealth);
    }
}
