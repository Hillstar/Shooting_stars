using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

    public GameObject explosion;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Asteroid")) // для моих и вр попадания по астероиду
        {
            Debug.Log("astBoom");
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            ScoreText.currentScore += 10;
            return;
        }

        if (col.CompareTag("Player") && (CompareTag("Enemy_Shoot") || CompareTag("Asteroid") || CompareTag("Enemy"))) // для вражеских снарядов и астероидов по мне
        {
            Debug.Log("PlayerBoom");
            //col.GetComponent<HealthScript>().currentHealth -= 1;
            //HealthTextScript.currentHealth -= 1;
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            return;
        }   

        if (col.CompareTag("Enemy") && CompareTag("Player_Shoot")) // для врагов
        {
            Debug.Log("EnemyBoom");
            col.gameObject.GetComponent<EnemyHealth>().currentHealth -= 1;
            Destroy(gameObject);
            ScoreText.currentScore += 20;
            return;
        }

        if ((col.CompareTag("Boss_body") || col.CompareTag("Boss_wing") || col.CompareTag("Missile")) && CompareTag("Player_Shoot")) // для босса
        {
            Debug.Log("BossBoom");
            col.gameObject.GetComponent<EnemyHealth>().currentHealth -= 1;
            Destroy(gameObject);
            return;
        }

        if (col.CompareTag("Player") && CompareTag("Missile")) // для ракета по мне
        {
            Debug.Log("PlayerBoom");
            //col.GetComponent<HealthScript>().currentHealth -= 2;
            //HealthTextScript.currentHealth -= 2;
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity);
            return;
        }
    }
}
