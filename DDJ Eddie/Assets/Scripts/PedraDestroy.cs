﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedraDestroy : MonoBehaviour
{
   void OnCollisionEnter2D (Collision2D collider)
    {
        if(collider.gameObject.tag == "Pedra" || collider.gameObject.tag == "Spikes")
        {
            Destroy(gameObject);
            
        }
        
    }
}