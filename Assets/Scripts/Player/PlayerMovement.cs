using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 3f;
	
	private float _movementHorizontal;
    private float _movementVertical;
    
	private void Update()
	{
		_movementVertical = Input.GetAxisRaw("Vertical");
        _movementHorizontal = Input.GetAxisRaw("Horizontal");
	}

    private void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + _movementHorizontal * speed * Time.deltaTime, -3f, 3f), 
            Mathf.Clamp(transform.position.y + _movementVertical * speed * Time.deltaTime,-4.8f, 4.8f), transform.position.z); 
        // clamp возвращает значение между мин и макс
    }
}
