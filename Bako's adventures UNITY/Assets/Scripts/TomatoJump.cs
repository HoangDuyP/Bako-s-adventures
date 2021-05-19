using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoJump : MonoBehaviour
{
    public Transform Tomato;
    public float value_;
    public float str_;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            Tomato.localScale = new Vector3(1f, 1f - value_, 1f);
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
            Tomato.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
