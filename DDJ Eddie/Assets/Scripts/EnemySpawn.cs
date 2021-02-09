using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //private float startTimer = 3f;
    private float spawnTimer = 8f;
    private int counter = 8;
    public GameObject EnemyPrefab;
    public GameObject BigEnemyPrefab;
    public GameObject LifeStealerPrefab;

    public GameObject keyPrefab;

    void Start()
    {
        //startTimer-=Time.deltaTime;

        int rand = Random.Range(1, 4);
        if (rand == 1)
        {
            Instantiate(EnemyPrefab, transform.position, transform.rotation);
        }
        else if (rand == 2)
        {
            Instantiate(BigEnemyPrefab, transform.position, transform.rotation);
        }
        else if (rand == 3)
        {
            Instantiate(LifeStealerPrefab, transform.position, transform.rotation);
        }

        
        counter -= 1;
        Debug.Log("start");
    }


    void Update()
    {
        spawnTimer -= Time.deltaTime;
        Debug.Log(spawnTimer);
        if (spawnTimer <= 0 && counter > 0)
        {
            Debug.Log("Tas");
            int rand = Random.Range(1, 4);
            if (rand == 1)
            {
                Instantiate(EnemyPrefab, transform.position, transform.rotation);
                
            }
            else if (rand == 2)
            {
                Instantiate(BigEnemyPrefab, transform.position, transform.rotation);
                
            }
            else if (rand == 3)
            {
                Instantiate(LifeStealerPrefab, transform.position, transform.rotation);
                
            }
            spawnTimer = 8f;
            spawnTimer -= Time.deltaTime;
            counter -= 1;
        }
        if (counter == 0)
        {
            Debug.Log("counter");
            Instantiate(keyPrefab, new Vector3(-1.9f,12.6f,-280.6f), transform.rotation);
            gameObject.GetComponent<EnemySpawn>().enabled = false;
        }
    }
}
