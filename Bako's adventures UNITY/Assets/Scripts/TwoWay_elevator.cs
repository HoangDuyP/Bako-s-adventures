using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoWay_elevator : MonoBehaviour
{
    public Transform Shiba;
    public Transform Shiba_Alter;
    public Rigidbody Elevator;
    public Transform Lever;
    public bool isUp_;
    public bool isActive_coroutine;
    private IEnumerator coroutine;
    private Vector3 topDestination;
    private Vector3 bottomDestination;
    private Vector3 refVelocity;
    
    private void Start()
    {
        isUp_ = true;
        isActive_coroutine = true;
        topDestination = new Vector3(-3.57f, 20f, 11.29f);
        bottomDestination = new Vector3(-3.57f, 7f, 11.29f);
    }
    private void Update()
    {
        Move();
        ResetPosition();
    }
    
    private void ResetPosition()
    {
        if(Elevator.IsSleeping() && Vector3.Distance(transform.position,topDestination) < 0.05f)
        {
            isActive_coroutine = true;
            coroutine = CountDown(5f);
            StartCoroutine(coroutine); // Coroutine chỉ cần kích hoạt 1 lần sẽ không dừng lại
           
        }
        if (isActive_coroutine == false)
            StopCoroutine(coroutine);
    }
    private IEnumerator CountDown(float time)
    {
        while(isActive_coroutine)
        {
            yield return new WaitForSeconds(time);
            transform.position = Vector3.SmoothDamp(transform.position, bottomDestination, ref refVelocity, 1f);
            if (isUp_ == false)
            { 
                Lever.Rotate(0f, 0f, 100f, Space.Self);
                isUp_ = true;
            }
            isActive_coroutine = false;
        }
        
    }
    private void Move()
    {
        shiba_Trigger();
        shibaAlter_Trigger();
        if (isUp_ == false)
        {
            transform.position = Vector3.SmoothDamp(transform.position, topDestination, ref refVelocity, 1f);
        }
        else
        {
            transform.position = Vector3.SmoothDamp(transform.position, bottomDestination, ref refVelocity, 1f);
        }
    }
    private void shiba_Trigger()
    {
        float distance_Shiba = Vector3.Distance(Shiba.position, Lever.position);
        if (distance_Shiba <= 2 && Input.GetButtonDown("Grab Left"))
        {
            if (Vector3.Distance(transform.position, bottomDestination) < 0.05f) // Đang ở dưới
            {
                Lever.Rotate(0f, 0f, -100f, Space.Self);
                isUp_ = false;
            }
            if (Vector3.Distance(transform.position, topDestination) < 0.05f) // Đang ở trên
            {
                Lever.Rotate(0f, 0f, 100f, Space.Self);
                isUp_ = true;
            }
        }
    }
    private void shibaAlter_Trigger()
    {
        float distance_Shiba_Alter = Vector3.Distance(Shiba_Alter.position, Lever.position);
        if (distance_Shiba_Alter <= 2 && Input.GetButtonDown("Grab Right"))
        {
            if (Vector3.Distance(transform.position, bottomDestination) < 0.05f)
            {
                Lever.Rotate(0f, 0f, -100f, Space.Self);
                isUp_ = false;
            }
            if (Vector3.Distance(transform.position, topDestination) < 0.05f)
            {
                Lever.Rotate(0f, 0f, 100f, Space.Self);
                isUp_ = true;
            }
        }
    }
}
