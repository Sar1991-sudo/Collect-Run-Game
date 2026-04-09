using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class MenuManager : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    void Start()
    {
        int score = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + score;
    }
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GOToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
