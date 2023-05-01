using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtSteve : MonoBehaviour {
    public float fireCooldown;
    public float fireVariance;
    public GameObject bullet;
    public float bulletSpeed;
    public Vector3 lead;
    protected GameObject Steve;
    protected float residualTime;
    void Start()
    {
        Steve = GameObject.Find("Steve");
        OnHasFired();
    }
    public void Update() {
        if (Steve == null) {
            return;
        }
        residualTime -= Time.deltaTime;
        if (residualTime <= 0f) {
            Fire();
        }
        if (Steve.transform.position.x - transform.position.x > 18f) {
            Destroy(gameObject);
        }
    }
    protected void Fire() {
        var firing = GameObject.Instantiate(bullet);
        firing.GetComponent<Rigidbody>().velocity = (Steve.transform.position + lead - transform.position).normalized * bulletSpeed;
        firing.transform.position = transform.position;
        Destroy(firing, 10f);
        OnHasFired();
    }
    protected void OnHasFired() {
        residualTime = fireCooldown + Random.Range(-fireVariance, fireVariance);
    }
}
