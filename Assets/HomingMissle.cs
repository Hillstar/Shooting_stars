using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissle : MonoBehaviour {

    public Transform target;

    public float moveSpeed = 3f;
    public float rotationSpeed = 3f;

    Rigidbody2D rb;

    private void Start() {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        Vector2 direction = (Vector2)target.transform.position - (Vector2)rb.position;

        direction.Normalize();

        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotationSpeed * rotateAmount;

        rb.velocity = transform.up * moveSpeed;
	}
}
