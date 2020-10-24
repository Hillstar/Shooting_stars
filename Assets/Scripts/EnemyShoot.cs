using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public GameObject shoot;
    public GameObject missile;
    public Transform[] gunsPosition;
    public Transform[] rocketPosition;

    public float shootDelay = 0.7f;

    float timeToShoot;

    public bool haveMissiles = false;

    public int ind = 1;

    public int laserAmount = 10;

    public int laserCounter = 0;

    void Start() {
            timeToShoot = Time.time + shootDelay;
    }

    void FixedUpdate()
    {

        if (!haveMissiles || (haveMissiles && laserCounter <= laserAmount))
        {
            if (Time.time > timeToShoot)
            {
                for (int i = 0; i < gunsPosition.Length; i++)
                    Instantiate(shoot, gunsPosition[i].transform.position, gunsPosition[i].transform.rotation);

                timeToShoot = Time.time + shootDelay;

                if(haveMissiles)
                    laserCounter++;
            }
        }

        else if (Time.time > timeToShoot && laserCounter >= laserAmount && haveMissiles)
        {
            for (int i = 0; i < rocketPosition.Length; i++)
                Instantiate(missile, rocketPosition[i].transform.position, transform.rotation);

            haveMissiles = false;

            timeToShoot = Time.time + 10f;
        }
    }
}
