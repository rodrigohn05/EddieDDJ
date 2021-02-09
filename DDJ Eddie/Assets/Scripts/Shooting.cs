using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject waterPrefab;
    public WaterBar wb;

    public static float time = 3f;  
    public float cd = 0f;
    public float cdTotal = 5f;

    public float waterForce = 20f;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if(sceneName == "TutorialRoom"){
//            Debug.Log("yes");
        cd = Time.time;
        wb.SetMaxWater(3f);
        }
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space) && time>0)
        {
            Shoot();
        }

        if(Input.GetKey(KeyCode.LeftShift) && time >0){
            PlayerMovement.moveSpeed=10f;
            time -=Time.deltaTime;
            wb.SetWater(time);
            if(time <=0 ){
                PlayerMovement.moveSpeed=5f;
            }
        }
        else {PlayerMovement.moveSpeed=5f;}


        DontDestroyOnLoad(transform.gameObject);
    }

    void Shoot(){
        GameObject water = Instantiate(waterPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = water.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * waterForce, ForceMode2D.Impulse);
        time -= Time.deltaTime;
        wb.SetWater(time);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Refill")
        {
        time = 3f;
        //Debug.Log("TRIGGER");
        wb.SetWater(time);
        }
        else if (collision.gameObject.tag == "Droplet")
        {
        time += 1f;
        if(time>=3f){
            time = 3f;
        }
        //Debug.Log("TRIGGER");
        wb.SetWater(time);
        }
    }
}
