using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject firePrefab;

    public float fireForce = 1f;

    public float time = 1f;

    void Update()
    {
        
        time -= Time.deltaTime;
    
        if (time <= 0)
        {
            Shoot();
        }
    }



    void Shoot(){
        GameObject fire = Instantiate(firePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * fireForce, ForceMode2D.Impulse);
        //rb.velocity = firePoint.right * fireForce;
        time = 1f;
        
    }
}
