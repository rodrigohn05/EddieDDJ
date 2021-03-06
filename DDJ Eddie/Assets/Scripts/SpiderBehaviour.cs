﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBehaviour : MonoBehaviour
{
    private Vector3 target = new Vector3 (-31.32f,10,0);
    private Vector3 targetDown = new Vector3(-31.32f,-10,0);
    private float speed = 7f;
    private int turn = 0;
    private SpriteRenderer sr;
    void Start()
    {
        
       
    }

    void Update()
    {
        if ( turn == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        }
        else 
        {
            transform.position = Vector3.MoveTowards(transform.position, targetDown, Time.deltaTime * speed);
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
    {
        if(turn == 0)
        {
            turn = 1;
            transform.localScale = new Vector3(1, 1, 1);            
        }
        else
        {
            turn = 0;
            transform.localScale = new Vector3(1, -1, 1);
        }
    }
}
