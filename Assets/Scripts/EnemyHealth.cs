using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public float MaxHealth = 3f;
    public float currentHealth;

    public GameObject explosion;
 
    void Start()  {
        currentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            if (CompareTag("Boss_body"))
            {
                Destroy(transform.parent.gameObject);
                ScoreText.currentScore += 100;
            }

            else if (CompareTag("Boss_wing"))
            {
                Destroy(gameObject);
                ScoreText.currentScore += 25;
            }

            else
                Destroy(gameObject);

            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}
