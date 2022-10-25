using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void StartGame () {
        SceneManager.LoadScene("GameScene");
    }
}
