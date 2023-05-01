using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRunner : MonoBehaviour
{
    public float Speed;
    public Transform[] waypoints;
    protected int lastReached;
    protected float residualTime;
    protected float timeBetween;
    public void Awake() {
        lastReached = -1;
        OnHitMilestone();
    }
    void Update()
    {
        residualTime += Time.deltaTime;
        if (residualTime > timeBetween) {
            OnHitMilestone();
        }
        if (lastReached >= waypoints.Length - 1) {
            transform.position = waypoints[waypoints.Length - 1].position;
            return;
        }
        transform.position = Vector3.Lerp(waypoints[lastReached].position, waypoints[lastReached + 1].position, residualTime / timeBetween);
    }
    protected void OnHitMilestone() {
        lastReached += 1;
        residualTime -= timeBetween;
        if (lastReached >= waypoints.Length - 1) {
            timeBetween = float.PositiveInfinity;
            Director.OnWin();
            return;
        }
        timeBetween = (waypoints[lastReached + 1].position - waypoints[lastReached].position).magnitude / Speed;
    }
}
