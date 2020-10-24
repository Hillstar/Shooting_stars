using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    float movementHorizontal;
    float movementVertical;

    public float speed = 3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        movementVertical = Input.GetAxisRaw("Vertical");
        movementHorizontal = Input.GetAxisRaw("Horizontal");
	}

    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + movementHorizontal * speed * Time.deltaTime, -3f, 3f), 
            Mathf.Clamp(transform.position.y + movementVertical * speed * Time.deltaTime,-4.8f, 4.8f), transform.position.z); 
        //clamp возвращает значение между мин и макс
    }
}
