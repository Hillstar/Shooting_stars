using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScoreText;
    
    private void Update()
    {
        highScoreText.text = " Score: " + PlayerPrefs.GetInt("HighScore");
    }
}
