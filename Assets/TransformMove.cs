using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMove : MonoBehaviour {

    public float speed = 3f;

    public bool inverseDirection = false;

    private void Start()
    {
        if (inverseDirection)
            speed *= -1;
    }

    void FixedUpdate () {
        transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
    }
}
