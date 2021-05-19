using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_controller_Fruit : MonoBehaviour
{
    public Transform Shiba;
    public Transform Shiba_Alter;
    public Transform Red_lever;
    public Transform Blue_lever;
    public BoxCollider Portal;
    public MeshRenderer Portal_Skin;
    bool Is_Red;
    bool Is_Blue;
    private void Start()
    {
        Portal_Skin.enabled = false;
        Portal.isTrigger = false;
    }
    private void Update()
    {
        Shiba_Trigger();
        Shiba_Alter_Trigger();
        Trigger_Portal();
    }
    private void Trigger_Portal()
    {
        if (Is_Red == true && Is_Blue == true)
        {
            Portal_Skin.enabled = true;
            Portal.isTrigger = true;
        }
    }
    private void Shiba_Trigger()
    {
        float distance_Red = Vector3.Distance(Shiba.position, Red_lever.position);
        float distance_Blue = Vector3.Distance(Shiba.position, Blue_lever.position);
        if (distance_Red <= 2 && Input.GetButtonDown("Grab Left"))
        {
            if (Is_Red == false)
            {
                Red_lever.Rotate(0f, 0f, -100f);
                Is_Red = true;
            }
        }
        if (distance_Blue <= 2 && Input.GetButtonDown("Grab Left"))
        {
            if (Is_Blue == false)
            {
                Blue_lever.Rotate(0f, 0f, -100f);
                Is_Blue = true;
            }
        }
    }
    private void Shiba_Alter_Trigger()
    {
        float distance_Red = Vector3.Distance(Shiba_Alter.position, Red_lever.position);
        float distance_Blue = Vector3.Distance(Shiba_Alter.position, Blue_lever.position);
        if (distance_Red <= 2 && Input.GetButtonDown("Grab Right"))
        {
            if (Is_Red == false)
            {
                Red_lever.Rotate(0f, 0f, -100f);
                Is_Red = true;
            }
        }
        if (distance_Blue <= 2 && Input.GetButtonDown("Grab Right"))
        {
            if (Is_Blue == false)
            {
                Blue_lever.Rotate(0f, 0f, -100f);
                Is_Blue = true;
            }
        }
    }
}
