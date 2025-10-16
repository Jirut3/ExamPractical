using UnityEngine;
using UnityEngine.UI;
using TMPro; // ถ้าใช้ TextMeshPro

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;

    private float timeLeft = 30f;
    public bool isGameOver = false;
    private int score = 0;

    void Start()
    {
        UpdateScore(0);
        gameOverText.text = "";
    }

    void Update()
    {
        if (isGameOver) return;

        timeLeft -= Time.deltaTime;
        timeText.text = "Time: " + Mathf.Ceil(timeLeft);

        if (timeLeft <= 0)
        {
            GameOver();
        }
    }

    public void UpdateScore(int newScore)
    {
        score = newScore;
        scoreText.text = "Score: " + score;
    }

    void GameOver()
    {
        isGameOver = true;
        gameOverText.text = "Time’s Up!";
    }
}