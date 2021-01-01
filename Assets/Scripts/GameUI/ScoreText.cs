using UnityEngine;
using UnityEngine.UI;

namespace UI.GameUI
{
	public class ScoreText : MonoBehaviour 
	{
		public Text scoreText;
		public static int currentScore;

		private void Start () 
		{
			currentScore = 0;
		}
		
		private void Update () 
		{
			scoreText.text = " Score: " + currentScore;
		}
	}
}
