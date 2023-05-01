using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.name.StartsWith("Bullet")) {
            Destroy(other.gameObject);
        }
    }
}
