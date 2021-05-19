using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterWaterSourceopen : MonoBehaviour
{
    public ParticleSystem Pipe1;
    public ParticleSystem Pipe2;
    private float countTime = 10f;
    private bool isWatering = false;
    private void Start()
    {
        Pipe1.Stop();
        Pipe2.Stop();
    }
    private void Update()
    {
        if (isWatering == true)
        {
            countTime -= Time.deltaTime;
        }
        if (countTime <= 0)
        {
            Pipe1.Stop();
            Pipe2.Stop();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shiba" || other.tag == "Shiba_Alter")
        {
            Pipe1.Play();
            Pipe2.Play();
            isWatering = true;
        }
    }
}
