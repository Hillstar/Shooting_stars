using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour 
{
    public float speed = 3f;
    public float range = 2f;

    private bool _isHere = false;

    private void FixedUpdate() 
    {
        // вместо анимации
        if (!_isHere)
        {
            if (transform.position.y > 3.5f)
                transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime * 0.5f, transform.position.z);

            else
                _isHere = true;
        }
        else
        {
            if (transform.position.x >= range || transform.position.x <= -range)
                speed *= -1;

            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime * -1, transform.position.y, transform.position.z);
        }
    }
}
