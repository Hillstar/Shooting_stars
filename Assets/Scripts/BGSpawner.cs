using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawner : MonoBehaviour {

    public GameObject[] planets;

    public float spawnDelay = 15f;

    float timeToSpawn;

    int previousIndex;

    void Start() {
        timeToSpawn = Time.time + spawnDelay;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > timeToSpawn)
        {
            int randomIndex = Random.Range(0, planets.Length);
            Vector3 newPos = new Vector3(Random.Range(-2.5f, 2.5f), transform.position.y + 7f, 0f);
            Instantiate(planets[randomIndex], newPos, Quaternion.identity);
            timeToSpawn = Time.time + spawnDelay;
        }
    }
}
