using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerIzq : MonoBehaviour
{
    public GameObject spawn;
    public float delay;
    public float interval;
    void Start()
    {
        InvokeRepeating("SpawnOne", delay, interval);
    }

    private void SpawnOne()
    {
        Vector3 spawnpos = transform.position + new Vector3(-2, 0, 0);
        Instantiate(spawn, spawnpos, Quaternion.identity);
    }
}

