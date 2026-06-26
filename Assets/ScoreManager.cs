using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    private UIManager uiManager;

    void Start()
    {
        uiManager = FindFirstObjectByType<UIManager>();
        if (uiManager != null)
            uiManager.UpdateScore(score);
    }

    public void AddScore(int points)
    {
        score += points;

        if (uiManager != null)
            uiManager.UpdateScore(score);
    }
}