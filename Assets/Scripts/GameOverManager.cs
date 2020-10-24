using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour {

    public HealthScript healthScript;       // Reference to the player's health.
   // public float restartDelay = 10f;         // Time to wait before restarting the level

    Animator anim;                          // Reference to the animator component.
   // float restartTimer;                     // Timer to count up to restarting the level

    public Button retryBut;
    public Button goMenuBut;


    void Awake() {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        // If the player has run out of health...
        if (healthScript.currentHealth <= 0)
        {
            // ... tell the animator the game is over.
            anim.SetTrigger("GameOver");

            retryBut.gameObject.SetActive(true);
            goMenuBut.gameObject.SetActive(true);

            //if(PlayerPrefs.GetInt("HighScore") < ScoreText.currentScore)
                PlayerPrefs.SetInt("HighScore", ScoreText.currentScore);
        }
    }

    public void goMainMenu() {
        SceneManager.LoadScene("Main_Menu");
    }

    public void PlayAgain() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
