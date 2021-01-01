using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour
{
    public float normalSpeed = 0.5f;
    public float boostSpeed = 7f;
    public float speedOfChange = 0.1f;
    
    private float _currentSpeed;

    private void Start()
    {
        if (GameObject.Find("Spawner").GetComponent<EnemySpawner>().waveType == 1)
            _currentSpeed = boostSpeed;
        else
            _currentSpeed = normalSpeed;
    }

    private void Update()
    {
        transform.position = new Vector3(0f, transform.position.y - _currentSpeed * Time.deltaTime, 0f);

        if(transform.position.y <= -11.5f)
            transform.position = new Vector3(0f, 11.5f, 0f);

        if (GameObject.Find("Spawner").GetComponent<EnemySpawner>().waveType == 1 && _currentSpeed < boostSpeed)
            _currentSpeed += speedOfChange; // чекаем на первый режим и ускоряем при надобности
        
        else if (GameObject.Find("Spawner").GetComponent<EnemySpawner>().waveType != 1 && _currentSpeed > normalSpeed)
            _currentSpeed -= speedOfChange; // замедляем 
	}
}
