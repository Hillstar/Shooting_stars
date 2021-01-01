using System.Collections;
using System.Collections.Generic;
using UI.GameUI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject player;
	public int scoreToAddHealth = 1000;
	
	private void Update()
    {
        if (ScoreText.currentScore >= scoreToAddHealth)
        {
            player.GetComponent<PlayerHealth>().currentHealth += 1;
            HealthTextScript.currentHealth += 1;
            scoreToAddHealth += 1000;
        }
	}
}
