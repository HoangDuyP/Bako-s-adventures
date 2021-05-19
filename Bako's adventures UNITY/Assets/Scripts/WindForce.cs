using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
public class WindForce : MonoBehaviour
{
    public float wind_str;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            other.attachedRigidbody.AddForce(Vector3.up * wind_str);
            other.attachedRigidbody.AddRelativeTorque(Vector3.up * wind_str);
        }
    }
}
