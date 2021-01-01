using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovement : MonoBehaviour
{
    public float speed = 3f;
    public bool inverseDirection = false;
    
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        if (inverseDirection)
            transform.Rotate(0f, 0f, 180f);
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = transform.up * speed;
    }       
}
