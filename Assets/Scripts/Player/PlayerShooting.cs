using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float shootDelay = 3f;
    public GameObject shoot;
    public Transform[] gunsPosition;

    private float _currentTime;
    private float _timeToShoot;
    private AudioSource _shootingAudio;
    
	private void Start()
    {
        _shootingAudio = GetComponent<AudioSource>();
        _timeToShoot = Time.time + shootDelay;
	}
    
	private void Update()
    {
        if(Input.GetKey("'") && Time.time >= _timeToShoot)
        {
            foreach (var t in gunsPosition)
                Instantiate(shoot, t.transform.position, Quaternion.identity);

            _shootingAudio.Play();
            _timeToShoot = Time.time + shootDelay;
        }
    }
}
