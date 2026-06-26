using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI phaseText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI youWinText;

    void Start()
    {
        if (gameOverText != null) gameOverText.gameObject.SetActive(false);
        if (youWinText != null) youWinText.gameObject.SetActive(false);
    }

    public void UpdateLives(int lives)
    {
        if (livesText != null)
            livesText.text = "LIVES: " + lives;
    }

    public void UpdateScore(int score)
    {
        if (scoreText != null)
            scoreText.text = "SCORE: " + score;
    }

    public void UpdatePhase(string phase)
    {
        if (phaseText != null)
            phaseText.text = phase;
    }

    public void UpdateTimer(int time)
    {
        if (timerText != null)
            timerText.text = "TIME: " + time;
    }

    public void ShowGameOver()
    {
        if (gameOverText != null)
            gameOverText.gameObject.SetActive(true);
    }

    public void ShowYouWin()
    {
        if (youWinText != null)
            youWinText.gameObject.SetActive(true);
    }
}