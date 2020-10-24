using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShoot : MonoBehaviour {

    public float speed = 3f;
    public bool inverseDirection = false;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (inverseDirection)
            transform.Rotate(0f, 0f, 180f);
    }

    void FixedUpdate() {
            rb.velocity = transform.up * speed;
    }       
}
