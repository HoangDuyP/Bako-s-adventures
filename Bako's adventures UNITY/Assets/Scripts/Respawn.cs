using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform Shiba;
    public Transform Shiba_Alter;
    public Transform RespawnPoint_Shiba;
    public Transform RespawnPoint_Shiba_Alter;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shiba" || other.gameObject.tag == "Shiba_Alter")
        {
            Shiba.position = RespawnPoint_Shiba.position;
            Shiba_Alter.position = RespawnPoint_Shiba_Alter.position;
        }
    }
}
