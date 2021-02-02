using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRaycastHit : MonoBehaviour
{
    public static int countB1=0;
    public static int countB2=0;
    public static int countB3=0;
    public static int countB4=0;
    public Transform firePoint;
 
    void Start()
    {
       //rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, transform.right);
        //Debug.DrawLine(transform.position, hit.point);
        if(hit.collider != null){
            //Debug.Log("hitei " +hit.collider.gameObject.tag + " "+ hit.point); 
            Debug.DrawLine(transform.position, hit.point);
            
            if(hit.collider.gameObject.CompareTag("Bubble") && gameObject.tag=="BigE1"){
                countB1=1;
            }
            //else{countB1=0;}
            else if(hit.collider.gameObject.CompareTag("Bubble") && gameObject.tag=="BigE2"){
                countB2=1;
            }
            //else{countB2=0;}
            else if(hit.collider.gameObject.CompareTag("Bubble") && gameObject.tag=="BigE3"){
                countB3=1;
            }
            //else{countB3=0;}
            else if(hit.collider.gameObject.CompareTag("Bubble") && gameObject.tag=="BigE4"){
                countB4=1;
            }
            else {
                countB1=0;
                countB2=0;
                countB3=0;
                countB4=0;
            }
            
        }

        
        
    }
}
