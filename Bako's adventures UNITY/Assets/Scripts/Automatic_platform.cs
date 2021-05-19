using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic_platform : MonoBehaviour
{
    public float speed = 0.5f;
    public bool Is_Top;
    private Vector3 Destination;
    private Vector3 Origin;
    private Vector3 Velocity;
    private void Start()
    {
        Destination = new Vector3(-24.85f, 6.820001f, -20.11f);
        Origin = new Vector3(-24.85f, 6.820001f, -33f); 
    }
    private void Update()
    {
        if(Is_Top == false)
        {
            transform.position = Vector3.SmoothDamp(transform.position, Destination, ref Velocity, speed);
            if (Vector3.Distance(transform.position, Destination) < 1f)
                Is_Top = true;
        }
        if(Is_Top == true)
        {
            transform.position = Vector3.SmoothDamp(transform.position, Origin, ref Velocity, speed);
            if (Vector3.Distance(transform.position, Origin) < 1f)
                Is_Top = false;
        }
    }
    
}
