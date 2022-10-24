using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    public void Setup(int score) {
        gameObject.SetActive(true);
        scoreText.text = score.ToString();
    }

    public void PauseButton () {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeButton () {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartButton () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MainMenuButton () {
        SceneManager.LoadScene("MainMenuScene");
        Time.timeScale = 1;
    }
}
