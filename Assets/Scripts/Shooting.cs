using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public float shootDelay = 3f;
    float currentTime;
    float timeToShoot;
    public GameObject shoot;
    public Transform[] gunsPosition;

    public AudioSource shootingAudio;

	// Use this for initialization
	void Start () {
        shootingAudio = GetComponent<AudioSource>();
        timeToShoot = Time.time + shootDelay;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("'") && Time.time >= timeToShoot)
        {
            for (int i = 0; i < gunsPosition.Length; i++)
                Instantiate(shoot, gunsPosition[i].transform.position, Quaternion.identity);

            shootingAudio.Play();

            timeToShoot = Time.time + shootDelay;
        }
    }
}
