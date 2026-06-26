using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 6;
    private UIManager uiManager;

    void Start()
    {
        uiManager = FindFirstObjectByType<UIManager>();
        if (uiManager != null)
            uiManager.UpdateLives(lives);
    }

    public void TakeDamage(int damage)
    {
        lives -= damage;

        if (uiManager != null)
            uiManager.UpdateLives(lives);

        if (lives <= 0)
        {
            if (uiManager != null)
                uiManager.ShowGameOver();

            Time.timeScale = 0f;
        }
    }
}