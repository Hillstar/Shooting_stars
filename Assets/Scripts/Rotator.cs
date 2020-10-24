using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float minSpeedRotation = -3f;
    public float maxSpeedRotation = 4f;

    public float rotSpeed = 100f;

    public bool randomRotation = false;

    void Start()
    {
        if (randomRotation)
            rotSpeed = Random.Range(minSpeedRotation, maxSpeedRotation);
    }

    void FixedUpdate()
    {
        transform.Rotate(0f, 0f, rotSpeed*Time.deltaTime);
    }
}
