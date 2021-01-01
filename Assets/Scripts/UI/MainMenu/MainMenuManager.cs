using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class MainMenuManager : MonoBehaviour
    {
        bool _goPlay = false;
        float _timer;

        public void PlayGame() {
            _goPlay = true;
            _timer = Time.time + 2f;
        }

        public void Quit() {
            Application.Quit();
        }

        private void Update ()
        {
            if (_goPlay && Time.time > _timer)
                SceneManager.LoadScene("Game");
        }
    }
}
