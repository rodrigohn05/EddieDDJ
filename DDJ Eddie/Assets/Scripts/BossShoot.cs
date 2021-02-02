using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject firePrefab;

    public float fireForce = 10f;
    public float tempoTotal = 8f;


    void Update()
    {
        tempoTotal -= Time.deltaTime;

        if (tempoTotal <= 0f)
        {
            Shoot();
            tempoTotal = 8f;
        }
    }

    void Shoot()
    {
        GameObject fire = Instantiate(firePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * fireForce, ForceMode2D.Impulse);
        rb.velocity = firePoint.right * fireForce;
        }
}