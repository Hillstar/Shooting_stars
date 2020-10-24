using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMove : MonoBehaviour {

    public float minSpeed = 1f;
    public float maxSpeed = 7f;

    public float speed = 4f;

    void Start()
    {
        //speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(3 * Mathf.Sin(2 * transform.position.y), transform.position.y + speed * Time.deltaTime * -1, transform.position.z);
    }
}
