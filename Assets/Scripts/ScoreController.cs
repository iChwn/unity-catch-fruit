using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{

    public Text scoreText;
    private int score;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }   
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if(target.tag == "Bird") {
            Destroy(target.gameObject);
            score++;
        }   
    }
}
