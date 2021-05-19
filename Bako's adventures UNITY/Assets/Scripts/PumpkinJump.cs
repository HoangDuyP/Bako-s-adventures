using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinJump : MonoBehaviour
{
    public Transform Pumpkin;
    public float value_;
    public float str_;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            Pumpkin.localScale = new Vector3(1f, 1f, 1f - value_);
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
            Pumpkin.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
