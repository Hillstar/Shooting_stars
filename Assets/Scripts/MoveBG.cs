using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBG : MonoBehaviour {

    public GameObject bg;

    public float normalSpeed = 0.5f;
    public float boostSpeed = 7f;

    float currentSpeed;

    public float speedOfChange = 0.1f;

    private void Start()
    {
        if (GameObject.Find("Spawner").GetComponent<SpawnWaves>().ind == 1)
            currentSpeed = boostSpeed;

        else
            currentSpeed = normalSpeed;
    }

    void Update ()
    {
        transform.position = new Vector3(0f, transform.position.y - currentSpeed * Time.deltaTime, 0f);

       if(transform.position.y <= -11.5f)
        {
            transform.position = new Vector3(0f, 11.5f, 0f);
        }

        if (GameObject.Find("Spawner").GetComponent<SpawnWaves>().ind == 1 && currentSpeed < boostSpeed)
            currentSpeed += speedOfChange; //чекаем на первый режим и ускоряем при надобности

        else if (GameObject.Find("Spawner").GetComponent<SpawnWaves>().ind != 1 && currentSpeed > normalSpeed)
            currentSpeed -= speedOfChange; //замедляем 
	}
}
