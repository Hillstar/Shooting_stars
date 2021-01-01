using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSpawner : MonoBehaviour 
{
    public GameObject[] planets;
    public float spawnDelay = 15f;

    private float _timeToSpawn;
    private int _previousIndex;

    private void Start() 
    {
        _timeToSpawn = Time.time + spawnDelay;
    }
    
    private void FixedUpdate()
    {
        if (Time.time > _timeToSpawn)
        {
            var randomIndex = Random.Range(0, planets.Length);
            var newPos = new Vector3(Random.Range(-2.5f, 2.5f), transform.position.y + 7f, 0f);
            Instantiate(planets[randomIndex], newPos, Quaternion.identity);
            _timeToSpawn = Time.time + spawnDelay;
        }
    }
}
