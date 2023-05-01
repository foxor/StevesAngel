using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragileHuman : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.name.StartsWith("Bullet")) {
            Destroy(gameObject);
            Director.OnPlayerDied();
        }
    }
}
