using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreHero : MonoBehaviour
{
    
public GameObject box1;
public GameObject box2;

  
    void Update()
    {
        
            
        Physics2D.IgnoreCollision(box1.GetComponent<Collider2D>(), box2.GetComponent<Collider2D>());
        
    }
}
