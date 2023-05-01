using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOutsideRange : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public MonoBehaviour ToToggle;
    void Update()
    {
        ToToggle.enabled = xMin < transform.position.x && transform.position.x < xMax;
    }
}
