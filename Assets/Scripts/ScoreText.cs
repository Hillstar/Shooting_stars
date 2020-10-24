using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text scoreText;

    public static int currentScore = 0;

	void Start () {

        currentScore = 0;
	}
	
	// Update is called once per frame
	void Update () {

        scoreText.text = " Score: " + currentScore;
	}
}
