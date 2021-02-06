using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public float speed =20f;
    public float dashTime;
    private float startDashTime;
    private int direction;
    private Rigidbody2D rb;
    //public static bool shift = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime=startDashTime;
    }

    void Update()
    {
        if(direction==0)
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow)){
                direction = 1;
            }
            else if(Input.GetKeyDown(KeyCode.RightArrow)){
                direction = 2;
            }
            if(Input.GetKeyDown(KeyCode.UpArrow)){
                direction = 3;
            }
            if(Input.GetKeyDown(KeyCode.DownArrow)){
                direction = 4;
            }
        }
        else{
            if(dashTime<=0){
                direction=0;
                dashTime=startDashTime;
                rb.velocity = Vector2.zero;
            }
            else{
                dashTime-=Time.deltaTime;

                if(direction == 1){
                    rb.velocity = Vector2.left * speed;
                }
                if(direction == 2){
                    rb.velocity = Vector2.right * speed;
                }
                if(direction == 3){
                    rb.velocity = Vector2.up * speed;
                }
                if(direction == 4){
                    rb.velocity = Vector2.down * speed;
                }
            }

        }

        }
    }

