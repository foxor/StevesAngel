using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ThingToSpawn;
    public float SpawnInterval;
    public float IntervalVariance;
    protected float residualTime;
    public void Awake() {
        OnSpawn();
    }
    public void Update() {
        residualTime -= Time.deltaTime;
        if (residualTime <= 0f) {
            Spawn();
        }
    }
    protected void Spawn() {
        var thing = GameObject.Instantiate(ThingToSpawn);
        thing.transform.position = transform.position;
        OnSpawn();
    }
    protected void OnSpawn() {
        residualTime += SpawnInterval + Random.Range(-IntervalVariance, IntervalVariance);
    }
}
