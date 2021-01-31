using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float moveSpeed = 3f;
    GameObject Find;


    public float stoppingDistance = 7f;
    public float retreatDistance = 2f;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
        

        

    }
    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        
            //rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));

            if(Vector2.Distance(transform.position, player.position) > stoppingDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            }
            else if(Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
            {
                transform.position = this.transform.position;
            }
            else if(Vector2.Distance(transform.position, player.position) < retreatDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, -moveSpeed * Time.deltaTime);
            }
    }

   
}
