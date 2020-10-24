using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSc : MonoBehaviour {

    public float lifeTime = 3f;

    float timeToDestroy;

	// Use this for initialization
	void Start () {

        timeToDestroy = Time.time + lifeTime;
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > timeToDestroy)
            Destroy(gameObject);
	}
}
