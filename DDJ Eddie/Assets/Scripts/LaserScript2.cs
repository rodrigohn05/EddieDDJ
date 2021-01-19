using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript2 : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public MeshCollider meshCollider;
    public Transform laserPosition;
    private Collision2D other;
    public float distance = 3f;
    
    

    
  
    private void Start()
    {
        lineRenderer.enabled = false;
    }

    private void Update()
    {
       // RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position, transform.right);

        Mesh mesh = new Mesh();
        lineRenderer.BakeMesh(mesh, true);
        meshCollider.sharedMesh = mesh;

        
        
        


        lineRenderer.SetPosition(0, laserPosition.position);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(lineRenderer.isVisible == true)
            {
                lineRenderer.enabled = false;
            }
            else
            {
                lineRenderer.enabled = true;
            }
        }
        if (hit2)
        {
            lineRenderer.SetPosition(1, hit2.point);
            
        }
        else{
            lineRenderer.SetPosition(1, transform.right);
            
        }
            
      /*  if(hit2 && hit2.collider.CompareTag("Player") == true)
        {
            lineRenderer.SetPosition(1, transform.right* 10);
            Debug.Log(hit2.collider.CompareTag("Enemy"));
        }
        }
        if(hit2){
            lineRenderer.SetPosition(1, hit2.point);
        }
        }
        else 
        {
        lineRenderer.SetPosition(1, hit2.point *10);
        } */
    }

}
