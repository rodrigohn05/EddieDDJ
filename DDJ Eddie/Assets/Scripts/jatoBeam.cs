using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jatoBeam : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform Hit;
    
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
        lineRenderer.useWorldSpace = true;
    }

    void Update()
    {
        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, transform.up);
        Debug.DrawLine(transform.position, hit2D.point);
        Hit.position = hit2D.point;
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, Hit.position);
        if (Input.GetKey(KeyCode.Space))
        {
            lineRenderer.enabled = true;
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }
}