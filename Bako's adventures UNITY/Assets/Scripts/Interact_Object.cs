using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Object : MonoBehaviour
{
    public Transform Shiba;
    public Transform Shiba_Alter;
    private Rigidbody Object_Body;
    private BoxCollider Object_Collider;
    private void Start()
    {
        Object_Body = GetComponent<Rigidbody>();
        Object_Collider = GetComponent<BoxCollider>();
    }
    private void Update()
    {
        Pick_Up();
    }
    private void Pick_Up()
    {
        float distance_Shiba = Vector3.Distance(Shiba.position, transform.position);
        float distance_Shiba_Alter = Vector3.Distance(Shiba_Alter.position, transform.position);
        if(distance_Shiba <= 2f && Input.GetButtonDown("Grab Left"))
        {
            Object_Body.useGravity = false;
            Object_Body.freezeRotation = true;
            Object_Body.isKinematic = true;
            transform.parent = Shiba;    
        }
        if ((transform.parent == Shiba) && Input.GetButtonDown("Jump Left"))
        {
            Object_Body.useGravity = true;
            Object_Body.freezeRotation = false;
            Object_Body.isKinematic = false;
            transform.parent = null;
        }
        if (distance_Shiba_Alter <= 2f && Input.GetButtonDown("Grab Right"))
        {
            Object_Body.useGravity = false;
            Object_Body.freezeRotation = true;
            Object_Body.isKinematic = true;
            transform.parent = Shiba_Alter;
        }
        if ((transform.parent == Shiba_Alter) && Input.GetButtonDown("Jump Right"))
        {
            Object_Body.useGravity = true;
            Object_Body.freezeRotation = false;
            Object_Body.isKinematic = false;
            transform.parent = null;
        }
    }
}
