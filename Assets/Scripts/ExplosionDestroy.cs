using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDestroy : MonoBehaviour
{
	public float lifeTime = 3f;

    private float _timeToDestroy;
    
	private void Start()
	{
		_timeToDestroy = Time.time + lifeTime;
	}
	
	private void Update()
	{
		if (Time.time > _timeToDestroy)
            Destroy(gameObject);
	}
}
