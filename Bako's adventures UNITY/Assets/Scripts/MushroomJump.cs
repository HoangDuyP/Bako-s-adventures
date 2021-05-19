using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomJump : MonoBehaviour
{
    public float value_ = 0.5f;
    public float str_  = 60f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            transform.localScale = new Vector3(1f, 1f , 1f - value_);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            other.attachedRigidbody.AddForce(Vector3.up * str_);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
