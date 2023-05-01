using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float Speed;
    public float SmoothTime;
    public Vector3 Velocity;
    void Update()
    {
        var plane = new Plane(Vector3.back, transform.position);
        var pointerRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        plane.Raycast(pointerRay, out var d);
        var targetPos = pointerRay.origin + pointerRay.direction * d;
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref Velocity, SmoothTime, Speed);
    }
}
