using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{

    public GameOverScreen GameOverScreen;
    public Text scoreText;
    private int score;

    public void GameOver() {
        GameOverScreen.Setup(score);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        bool objectTag = gameObject.CompareTag("PipeHole");
        if(objectTag && target.tag == "Bomb") {
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            GameOver();
            Time.timeScale = 0;
        }   
    }

    void OnTriggerExit2D(Collider2D target)
    {
        bool objectTag = gameObject.CompareTag("PipeHole");
        if(objectTag && target.tag == "Bird") {
            Destroy(target.gameObject);
            score++;

            if(score > PlayerPrefs.GetInt("HighScore", 0)) {
                PlayerPrefs.SetInt("HighScore", score);
            }
        }   
    } 
}
