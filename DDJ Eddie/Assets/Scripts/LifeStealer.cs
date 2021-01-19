using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeStealer : MonoBehaviour
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
        if (time <= 0)
        {
            currentHealth -= 1;
            hb.SetHealth(currentHealth);
            time=1;
        }

        if (currentHealth<=0)
        {
            Destroy(gameObject);
                
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "Player"){
            currentHealth = maxHealth;
            hb.SetHealth(currentHealth);
            time = 1;
            Debug.Log("Trigger LifeStealer");
            
        }
        
    }

    
}
