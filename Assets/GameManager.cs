using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public int highScore = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject restartButton;
    public GameObject gameOverPanel;
    public AudioSource audioSource;
    public AudioClip coinSound;
    public AudioClip gameOverSound;

    void Awake()
    {
        instance = this;

        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateUI();
        audioSource.PlayOneShot(coinSound);
    }

    public void AddScore()
    {
        audioSource.PlayOneShot(coinSound);
        score++;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GOToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}