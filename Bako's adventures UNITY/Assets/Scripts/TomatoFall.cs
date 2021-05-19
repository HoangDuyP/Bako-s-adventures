using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoFall : MonoBehaviour
{
    public Rigidbody Tomato;
    void Start()
    {
        Tomato = gameObject.GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Shiba" || other.gameObject.tag == "Shiba_Alter")
        {
            Invoke("TriggerFall", 3f);
        }
    }
    void TriggerFall()
    {
        Tomato.isKinematic = false;
    }
}
