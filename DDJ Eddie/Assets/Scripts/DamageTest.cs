using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
    public int maxHealth = 5;
    
    private float time = 1f;

    public int currentHealth;

    public HealthBar hb;

    void Start()
    {
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    

    void TakeDamage(int damage)
    {
        
        currentHealth -= damage;

        hb.SetHealth(currentHealth);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Enemy" && collision.gameObject.tag == "Spike"){
            time -=Time.deltaTime;
            if(time<=0){
                
            TakeDamage(1);
            time = 1;
            }
        
        }
    }
}
