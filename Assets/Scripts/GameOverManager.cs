using System.Collections;
using System.Collections.Generic;
using UI.GameUI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;          // Reference to the player's health.
   // public float restartDelay = 10f;         // Time to wait before restarting the level
   
    public Button retryBut;
    public Button goMenuBut;
    
    private Animator _anim;                          // Reference to the animator component.
    // private float _restartTimer;                  // Timer to count up to restarting the level
    
    
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    
    private void Update()
    {
        // If the player has run out of health...
        if (playerHealth.currentHealth <= 0)
        {
            // ... tell the animator the game is over.
            _anim.SetTrigger("GameOver");

            retryBut.gameObject.SetActive(true);
            goMenuBut.gameObject.SetActive(true);

            //if(PlayerPrefs.GetInt("HighScore") < ScoreText.currentScore)
            PlayerPrefs.SetInt("HighScore", ScoreText.currentScore);
        }
    }

    public void GoMainMenu() 
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
