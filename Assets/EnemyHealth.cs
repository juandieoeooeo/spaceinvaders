using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 1;
    public int points = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            ScoreManager scoreManager = FindFirstObjectByType<ScoreManager>();

            if (scoreManager != null)
            {
                scoreManager.AddScore(points);
            }

            Destroy(gameObject);
        }
    }
}