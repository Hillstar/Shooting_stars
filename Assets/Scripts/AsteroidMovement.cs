using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour 
{
    public float minSpeed = 1f;
    public float maxSpeed = 7f;
    public bool randomSpeed = false;
    public float speed;

    private void Start()
    {
        if(randomSpeed)
            speed = Random.Range(minSpeed, maxSpeed);
    }

    private void FixedUpdate() 
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime* -1, transform.position.z);
    }
}
