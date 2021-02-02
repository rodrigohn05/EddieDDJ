using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PedraDestroy : MonoBehaviour
{
   // public GameObject Enemy1;
    public GameObject Enemy2;
    //public GameObject Enemy3;
    

   void OnCollisionEnter2D (Collision2D collider)
    {
        if(collider.gameObject.tag == "BossFire")
        {
            
            Destroy(gameObject);
            GameObject enemy = Instantiate(Enemy2, transform.position, transform.rotation);
        }
        
    }
  /*  void SpawnEnemy(){
        int spawn = Random.Range(1,4);
        
        if(spawn == 1){
            GameObject enemy = Instantiate(Enemy1, transform.position, transform.rotation);
        }
        else if(spawn == 2){
            GameObject enemy = Instantiate(Enemy2, transform.position, transform.rotation);
        }
        else if(spawn == 3){
            GameObject enemy = Instantiate(Enemy3, transform.position, transform.rotation);
        }
    }*/
}
