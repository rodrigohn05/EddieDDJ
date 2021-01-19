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
        
        if (time <=0 && collision.gameObject.tag == "Spikes"){
            takeDamage();
            time = 1;
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
