using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveTracker : MonoBehaviour {
    public Transform Steve;
    public float XMin;
    public float XMax;
    public void LateUpdate() {
        if (Steve == null) {
            return;
        }

        transform.position = new Vector3(Mathf.Clamp(Steve.position.x, XMin, XMax), 0f, -10f);
    }
}
