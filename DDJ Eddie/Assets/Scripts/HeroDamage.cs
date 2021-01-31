using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDamage : MonoBehaviour
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

        DontDestroyOnLoad(transform.gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision){
        
        if (time <=0 && collision.gameObject.tag == "Spikes" || time<=0 && collision.gameObject.tag == "Enemy" || time<=0 && collision.gameObject.tag == "Fireball"|| time<=0 && collision.gameObject.tag == "Lifestealer" || time<=0 && collision.gameObject.tag == "Spider"){
            takeDamage();
            time = 1;
            if (currentHealth<=0){
                Destroy(gameObject);
                
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Heart")
        {
            currentHealth += 1;
            hb.SetHealth(currentHealth);
        }
        else if(time <=0 && collider.gameObject.tag == "Fire"){
            takeDamage();
            time=1f;
            if (currentHealth<=0){
                Destroy(gameObject);
                Debug.Log("Morreu");
            }
        }
    }

    void takeDamage(){
        currentHealth -= 1;
        hb.SetHealth(currentHealth);
    }
}
