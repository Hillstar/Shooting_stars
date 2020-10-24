using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    bool goPlay = false;

    float timer;

    public void PlayGame() {
        goPlay = true;
        timer = Time.time + 2f;
    }

    public void Quit() {
        Application.Quit();
    }

    void Update ()
    {
        if (goPlay && Time.time > timer)
            SceneManager.LoadScene("01");
    }
}
