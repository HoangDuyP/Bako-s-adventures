using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowFruit : MonoBehaviour
{
    public GameObject SeedFruit;
    private Animator GrowingFruit;
   
    private void Start()
    {
        GrowingFruit = SeedFruit.GetComponent<Animator>();
    }
    private void OnParticleCollision(GameObject other)
    {
        
        GrowingFruit.enabled = true;
    }
}
