using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 30000f;
    public float currentHealth;
    public GameObject explosion;

    private void Start()
    {
        currentHealth = maxHealth;
	}
    
	private void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
