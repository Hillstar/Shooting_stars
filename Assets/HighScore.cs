using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public Text highScoreText;

    // Update is called once per frame
    void Update() {
        highScoreText.text = " Score: " + PlayerPrefs.GetInt("HighScore");
    }
}
