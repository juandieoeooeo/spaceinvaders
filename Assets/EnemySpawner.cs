using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f;

    private bool spawning = false;

    void Start()
    {
        StartSpawning();
    }

    public void SetEnemyPrefab(GameObject newPrefab)
    {
        enemyPrefab = newPrefab;
    }

    public void SetSpawnRate(float newRate)
    {
        spawnRate = newRate;

        if (spawning)
        {
            CancelInvoke(nameof(SpawnEnemy));
            InvokeRepeating(nameof(SpawnEnemy), 1f, spawnRate);
        }
    }

    public void StartSpawning()
    {
        spawning = true;

        CancelInvoke(nameof(SpawnEnemy));
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnRate);
    }

    public void StopSpawning()
    {
        spawning = false;
        CancelInvoke(nameof(SpawnEnemy));
    }

    void SpawnEnemy()
    {
        if (!spawning || enemyPrefab == null)
            return;

        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            transform.position.y + Random.Range(-5f, 5f),
            transform.position.z + Random.Range(-20f, 20f)
        );

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}