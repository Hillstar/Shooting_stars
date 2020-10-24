using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject player;

    public int scoreToAddHealth = 1000;
	
	// Update is called once per frame
	void Update ()
    {
        if (ScoreText.currentScore >= scoreToAddHealth)
        {
            player.GetComponent<HealthScript>().currentHealth += 1;
            HealthTextScript.currentHealth += 1;
            scoreToAddHealth += 1000;
        }
	}
}
