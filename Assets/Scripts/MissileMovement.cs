using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MissileMovement : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 3f;
    public float rotationSpeed = 3f;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        var direction = (Vector2)target.transform.position - (Vector2)_rigidbody.position;
        direction.Normalize();
        var rotateAmount = Vector3.Cross(direction, transform.up).z;
        
        _rigidbody.angularVelocity = -rotationSpeed * rotateAmount;
        _rigidbody.velocity = transform.up * moveSpeed;
	}
}
