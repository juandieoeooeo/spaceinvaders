using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int health = 60;
    public int points = 5000;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Boss tocó: " + other.name + " Tag: " + other.tag);

        if (other.CompareTag("bullet"))
        {
            health--;

            Debug.Log("Vida del Boss: " + health);

            Destroy(other.gameObject);

            if (health <= 0)
            {
                ScoreManager scoreManager = FindFirstObjectByType<ScoreManager>();

                if (scoreManager != null)
                {
                    scoreManager.AddScore(points);
                }

                Debug.Log("YOU WIN");
                Time.timeScale = 0f;

                Destroy(gameObject);
            }
        }
    }
}