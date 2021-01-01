using UnityEngine;
using UnityEngine.UI;

namespace UI.GameUI
{
    public class HealthTextScript : MonoBehaviour
    {
        public Text healthText;
        public static float currentHealth;
        public float maxHealth = 3f;

        private void Start()
        {
            healthText = GetComponent<Text>();
            currentHealth = maxHealth;
        }
        
        private void Update()
        {
            healthText.text = " Health: " + currentHealth;
        }
    }
}
