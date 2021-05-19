using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicCamera : MonoBehaviour
{
    private Camera ZoomCamera;
    private Vector3 Velocity;
    public Transform Shiba;
    public Transform Shiba_Alter;
    public Vector3 offset;
    public float zoomValue_ = 5f;
    private void Start()
    {
        ZoomCamera = GetComponent<Camera>();
    }
    private void LateUpdate()
    {
        Move_camera();
        Zoom_camera();
    }
    private void Move_camera()
    {
        Vector3 centerPoint = Get_centerPoint();
        Vector3 newPosition = centerPoint + offset;
        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref Velocity, 0.5f);
    }
    private Vector3 Get_centerPoint()
    {
        Bounds Shiba_Bounds = new Bounds(Shiba.position, Vector3.zero);
        Shiba_Bounds.Encapsulate(Shiba_Alter.position);
        return Shiba_Bounds.center;
    }
    private void Zoom_camera()
    {
        if (Input.GetButtonDown("Zoom"))
        {
            float IsZoom = Input.GetAxis("Zoom");
            if (ZoomCamera.fieldOfView > 35 && ZoomCamera.fieldOfView < 85)
                ZoomCamera.fieldOfView += IsZoom * zoomValue_;
            if (ZoomCamera.fieldOfView <= 35)
            {
                ZoomCamera.fieldOfView += Math.Abs(IsZoom) * zoomValue_;
            }
            if (ZoomCamera.fieldOfView >= 85)
            {
                ZoomCamera.fieldOfView -= Math.Abs(IsZoom) * zoomValue_;
            }
        }
        if (Input.GetButtonDown("Reset"))
        {
            ZoomCamera.fieldOfView = 60f;
        }
    }
}
