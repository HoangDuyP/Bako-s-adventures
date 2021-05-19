using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public Transform FanBlade;
    public float FanSpeed;
    public bool Is_On = true;
    float On_Off_Timer = 25f;
    void Update()
    {
        FanBlade.Rotate(0f, 0f, On_Off_Timer * FanSpeed * Time.deltaTime);
        if(Is_On == false)
        {
            if(On_Off_Timer > 0)
                On_Off_Timer -= 0.1f;    
        }
        else
            On_Off_Timer = 25f;
        // 
        //CreateWindEffect()
    }
    
}
