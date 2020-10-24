﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaves : MonoBehaviour {

    public GameObject[] enemies;
    public GameObject[] asteroids;
    public GameObject shuriken;
    public GameObject Boss;

    bool isBossHere = false;

    public float asteroidsDelay = 1f;
    public int asteroidsAmount = 30;

    public float delayAfterBoss = 10f;

    public float spawnDelay = 3f;
    public float waveDelay = 5f;
    
    public int objectCounter;
    public int enemyAmount = 15;

    public float shurikensDelay = 0.9f;
    public int shurikensAmount = 5;

    float timeToSpawn;

    public int ind = 1;

    // Use this for initialization
    void Start () {

        objectCounter = 0;
        timeToSpawn = Time.time + spawnDelay + 2;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        switch (ind)
        {
            case 1: //режим астероидов
                if (Time.time > timeToSpawn && objectCounter < asteroidsAmount)
                {
                    int randomIndex = Random.Range(0, asteroids.Length);
                    Vector3 newPos = new Vector3(Random.Range(-3f, 3f), transform.position.y, 0f);
                    Instantiate(asteroids[randomIndex], newPos, Quaternion.Euler(0f, 0f, 180f));
                    timeToSpawn = Time.time + asteroidsDelay;
                    objectCounter++;
                    Debug.Log(objectCounter);
                }

                else if (objectCounter >= asteroidsAmount)
                {
                    Debug.Log("wave out");
                    objectCounter = 0;
                    timeToSpawn = Time.time + waveDelay;
                    ind = 2; // переходим в режим врагов
                }
                break;

            case 2: // режим врагов
                if (Time.time > timeToSpawn && objectCounter < enemyAmount)
                {
                    int randomIndex = Random.Range(0, enemies.Length);
                    Vector3 newPos = new Vector3(Random.Range(-3f, 3f), transform.position.y, 0f);
                    Instantiate(enemies[randomIndex], newPos, Quaternion.Euler(0f, 0f, 180f));
                    timeToSpawn = Time.time + spawnDelay;
                    objectCounter++;
                    Debug.Log(objectCounter);
                }
                
                else if (objectCounter >= enemyAmount)
                {
                    Debug.Log("wave out");
                    objectCounter = 0;
                    timeToSpawn = Time.time + waveDelay;
                    ind = 3; // переходим в режим сюрикенов
                }
                break;

            case 3: //сюрикены  
                if (shurikensAmount != 0 && Time.time > timeToSpawn)
                {
                    Instantiate(shuriken, new Vector3(-2.9f, transform.position.y, 0f), Quaternion.identity);
                    shurikensAmount--;
                    timeToSpawn = Time.time + shurikensDelay;
                }

                else if (shurikensAmount == 0)
                {
                    shurikensAmount = 2;
                    ind = 4;
                    timeToSpawn = Time.time + waveDelay;
                }

                break;

            case 4: //режим босса      
                if (!isBossHere && Time.time > timeToSpawn)
                {
                    Instantiate(Boss, new Vector3(transform.position.x, transform.position.y + 1.9f, transform.position.z), Quaternion.Euler(0f , 0f, 180f));
                    isBossHere = true;
                }

                else
                {
                    if (GameObject.Find("Boss(Clone)") == null && isBossHere)
                    {
                        Debug.Log("ne nazhel");
                        ind = 1;
                        timeToSpawn = Time.time + delayAfterBoss;
                        isBossHere = false;
                    }
                }
                break;
        }
    }
}
