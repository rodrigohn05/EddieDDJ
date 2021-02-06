using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    private float time=0.25f;

    public static int key1;
    public static int key2;
    public static int key3;
    public static int key4;


    public Animator animator;

    Vector2 movement;

    void Start(){
        //SoundManager.PlaySound("music");
    }

    void Update()
    {
        time -=Time.deltaTime;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = new Vector2(movement.x, movement.y).normalized;
        
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);        
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag =="Key1"){
            TextKey.keys +=1;
            key1=1;
        }
        if(collision.gameObject.tag =="Key2"){
            TextKey.keys +=1;
            key2=1;
        }
        if(collision.gameObject.tag =="Key3"){
            TextKey.keys +=1;
            key3=1;
        }
        if(collision.gameObject.tag =="Key4"){
            TextKey.keys +=1;
            key4=1;
            SceneManager.LoadScene(7);
        }
        
    }

};
