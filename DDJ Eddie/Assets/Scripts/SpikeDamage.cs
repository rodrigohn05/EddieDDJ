using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{
    public float time=1f;
    public int maxHealth;
    private int currentHealth;
    public HealthBar hb;

    public static bool dead = false;

    public GameObject keyPrefab;
    public GameObject dropletPrefab;


    void Start(){
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);
    }
    void Update(){
        time -= Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "MiniFire" ){
            takeDamage();
            if (currentHealth<=0){
                if(gameObject.tag=="Boss"){
                    GameObject keyF = Instantiate(keyPrefab, transform.position, transform.rotation);
                    dead = true;
                }
                Destroy(gameObject);
                
            }
        }
        if (collision.gameObject.tag == "Bomb" ){
            takeDamageBomb();
            if (currentHealth<=0){
                if(gameObject.tag=="Boss"){
                    GameObject keyF = Instantiate(keyPrefab, transform.position, transform.rotation);
                    dead = true;
                }
                Destroy(gameObject);
                
                
            }
        }
        if (collision.gameObject.tag == "Spikes" ){
            takeDamage();
            if (currentHealth<=0){
                Destroy(gameObject);
                
            }
        }
    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Fire"){
            takeDamage();
            if (currentHealth<=0){
                Destroy(gameObject);
                
            }
        }
    }

    void takeDamage(){
        currentHealth -= 1;
        hb.SetHealth(currentHealth);
        if(gameObject.tag=="Boss"){
            Instantiate(dropletPrefab, transform.position, transform.rotation);
        }
    }
    void takeDamageBomb(){
        currentHealth -= 4;
        hb.SetHealth(currentHealth);
        if(gameObject.tag=="Boss"){
            Instantiate(dropletPrefab, transform.position, transform.rotation);
        }
    }
}
