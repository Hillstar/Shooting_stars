using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextScript : MonoBehaviour
{

    public Text HealthText;

    public static float currentHealth = 0f;

    public float maxHealth = 3f;

    void Start() {

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update(){

        HealthText.text = " Health: " + currentHealth;
    }
}
