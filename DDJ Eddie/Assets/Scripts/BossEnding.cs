using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnding : MonoBehaviour
{
    //private bool dead = false;
    //private Transform boss;
    public GameObject pedra;

    public static bool dead;
    void Update()
    {
        if (SpikeDamage.dead == true){
            //dead = true;
            GameObject pedraSpawn =  Instantiate(pedra, transform.position, transform.rotation);
            pedraSpawn.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
            
            Destroy(gameObject);
        }

    }
}
