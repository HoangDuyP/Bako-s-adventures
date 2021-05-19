using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_teleporter : MonoBehaviour
{
    public Transform Shiba_Respawn;
    public Transform Shiba_Alter_Respawn;
    // Start is called before the first frame update
    int Count;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            Count++;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(Count == 2)
        {
            if (other.tag == "Shiba")
            {
                other.transform.position = Shiba_Respawn.position;
            }
            if (other.tag == "Shiba_Alter")
            {
                other.transform.position = Shiba_Alter_Respawn.position;
            }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            Count--;
        }
    }
}
