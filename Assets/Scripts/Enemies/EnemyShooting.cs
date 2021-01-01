using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour 
{
    public GameObject shoot;
    public GameObject missile;
    public Transform[] gunsPosition;
    public Transform[] rocketPosition;
    
    public float shootDelay = 0.7f;
    public bool haveMissiles = false;
    public int laserAmount = 10;
    public int laserCounter = 0;
    
    private float _timeToShoot;

    private void Start()
    {
        _timeToShoot = Time.time + shootDelay;
    }

    private void FixedUpdate()
    {
        if (!haveMissiles || (haveMissiles && laserCounter <= laserAmount))
        {
            if (Time.time > _timeToShoot)
            {
                for (var i = 0; i < gunsPosition.Length; i++)
                    Instantiate(shoot, gunsPosition[i].transform.position, gunsPosition[i].transform.rotation);

                _timeToShoot = Time.time + shootDelay;
                if(haveMissiles)
                    laserCounter++;
            }
        }

        else if (Time.time > _timeToShoot && laserCounter >= laserAmount && haveMissiles)
        {
            for (var i = 0; i < rocketPosition.Length; i++)
                Instantiate(missile, rocketPosition[i].transform.position, transform.rotation);

            haveMissiles = false;
            _timeToShoot = Time.time + 10f;
        }
    }
}
