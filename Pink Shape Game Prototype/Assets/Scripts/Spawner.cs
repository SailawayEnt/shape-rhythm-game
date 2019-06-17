using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject note;

    private float timeBtwSpawn;

    public float startTimeBtwSpawn;

    public bool hasStarted;

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(note, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}