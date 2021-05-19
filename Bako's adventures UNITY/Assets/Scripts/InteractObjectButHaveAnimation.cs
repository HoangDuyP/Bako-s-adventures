using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObjectButHaveAnimation : MonoBehaviour
{
    public Transform Shiba;
    public Transform Shiba_Alter;
    public float DistanceForActive = 4f;
    private Animator Object_Body;
    //private BoxCollider Object_Collider;
    private void Start()
    {
        Object_Body = GetComponent<Animator>();
    }
    private void Update()
    {
        //Pick_Up();
        PressSomeThing();
    }
    private void PressSomeThing()
    {
        float distance_Shiba = Vector3.Distance(Shiba.position, transform.position);
        float distance_Shiba_Alter = Vector3.Distance(Shiba_Alter.position, transform.position);
        if (distance_Shiba <= DistanceForActive && Input.GetButtonDown("Grab Left"))// shiba open door
        {
            Object_Body.enabled = true;
        }
        if (distance_Shiba_Alter <= DistanceForActive && Input.GetButtonDown("Grab Right"))// AlterShiba open door
        {
            Object_Body.enabled = true;
        }
    }
}
