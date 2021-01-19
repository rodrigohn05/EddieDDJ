using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject waterPrefab;
    public WaterBar wb;
    
    
    public float time = 3f;  
    public float cd = 0f;
    public float cdTotal = 5f;

    public float waterForce = 20f;

    void Start()
    {
        cd = Time.time;
        wb.SetMaxWater(time);
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space) && time>0)
        {
            Shoot();
        }

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
    }
}
