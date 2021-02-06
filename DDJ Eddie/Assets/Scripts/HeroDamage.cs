using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroDamage : MonoBehaviour
{
    public float time=0.2f;
    public int maxHealth;
    private int currentHealth;
    public HealthBar hb;

    //public static int deaths=0;

    //public DeathScreen ds;

    void Start(){
        currentHealth = maxHealth;
        hb.SetMaxHealth(maxHealth);
    }
    void Update(){
        time -= Time.deltaTime;

        DontDestroyOnLoad(transform.gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision){
        
        if (time <=0 && collision.gameObject.tag == "Spikes" || time<=0 && collision.gameObject.tag == "Enemy" || time<=0 && collision.gameObject.tag == "Fireball"|| time<=0 && collision.gameObject.tag == "Lifestealer" || time<=0 && collision.gameObject.tag == "Spider" || time<=0 && collision.gameObject.tag == "MiniFire" || time<=0 && collision.gameObject.tag == "BossFire"){
            takeDamage();
            time = 0.2f;
            if (currentHealth<=0){
                SceneManager.LoadScene(6);
               //Destroy(gameObject);
                gameObject.transform.position = new Vector3 (0,0,0);
                currentHealth=8;
                hb.SetHealth(currentHealth);
                TextKey.deaths +=1;
                
            }
        }
        if(time<=0 && collision.gameObject.tag == "Bomb"){
            takeDamageBomb();
            time = 0.2f;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Heart")
        {
            currentHealth += 3;
            hb.SetHealth(currentHealth);
        }
        else if(time <=0 && collider.gameObject.tag == "Fire"){
            takeDamage();
            time=0.2f;
            if (currentHealth<=0){
                SceneManager.LoadScene(6);
                //Destroy(gameObject);
                gameObject.transform.position = new Vector3 (0,0,0);               
                currentHealth=8;
                hb.SetHealth(currentHealth);
                TextKey.deaths+=1;
            }
        }
    }

    void takeDamage(){
        currentHealth -= 1;
        hb.SetHealth(currentHealth);
    }

    void takeDamageBomb(){
        currentHealth -= 2;
        hb.SetHealth(currentHealth);
    }


}
