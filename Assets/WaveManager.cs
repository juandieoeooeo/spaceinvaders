using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour
{
    public EnemySpawner enemySpawner;

    public GameObject enemyBasic;
    public GameObject enemyFast;
    public GameObject enemyTank;
    public GameObject enemyHeavy;
    public GameObject enemyZigZag;

    public GameObject bossPrefab;
    public Transform bossSpawnPoint;
    public Transform bossBattlePoint;

    private UIManager uiManager;

    void Start()
    {
        uiManager = FindFirstObjectByType<UIManager>();
        StartCoroutine(StartWaves());
    }

    IEnumerator StartWaves()
    {
        Debug.Log("PHASE 1 - BASIC");
        if (uiManager != null) uiManager.UpdatePhase("PHASE 1");

        enemySpawner.SetEnemyPrefab(enemyBasic);
        enemySpawner.SetSpawnRate(2f);
        enemySpawner.StartSpawning();
        yield return StartCoroutine(RunPhase(30f));

        enemySpawner.StopSpawning();
        yield return new WaitForSeconds(15f);

        Debug.Log("PHASE 2 - FAST");
        if (uiManager != null) uiManager.UpdatePhase("PHASE 2");

        enemySpawner.SetEnemyPrefab(enemyFast);
        enemySpawner.SetSpawnRate(1.5f);
        enemySpawner.StartSpawning();
        yield return StartCoroutine(RunPhase(30f));

        enemySpawner.StopSpawning();
        yield return new WaitForSeconds(15f);

        Debug.Log("PHASE 3 - TANK");
        if (uiManager != null) uiManager.UpdatePhase("PHASE 3");

        enemySpawner.SetEnemyPrefab(enemyTank);
        enemySpawner.SetSpawnRate(1.8f);
        enemySpawner.StartSpawning();
        yield return StartCoroutine(RunPhase(30f));

        enemySpawner.StopSpawning();
        yield return new WaitForSeconds(15f);

        Debug.Log("PHASE 4 - HEAVY");
        if (uiManager != null) uiManager.UpdatePhase("PHASE 4");

        enemySpawner.SetEnemyPrefab(enemyHeavy);
        enemySpawner.SetSpawnRate(1.4f);
        enemySpawner.StartSpawning();
        yield return StartCoroutine(RunPhase(5f));

        enemySpawner.StopSpawning();
        yield return new WaitForSeconds(6f);

        Debug.Log("PHASE 5 - ZIGZAG");
        if (uiManager != null) uiManager.UpdatePhase("PHASE 5");

        enemySpawner.SetEnemyPrefab(enemyZigZag);
        enemySpawner.SetSpawnRate(1.2f);
        enemySpawner.StartSpawning();
        yield return StartCoroutine(RunPhase(30f));

        enemySpawner.StopSpawning();
        yield return new WaitForSeconds(15f);

        Debug.Log("BOSS INCOMING");
        if (uiManager != null)
        {
            uiManager.UpdatePhase("BOSS");
            uiManager.UpdateTimer(0);
        }

        GameObject boss = Instantiate(
            bossPrefab,
            bossSpawnPoint.position,
            Quaternion.identity
        );

        BossController bossController = boss.GetComponent<BossController>();

        if (bossController != null)
        {
            bossController.battlePosition = bossBattlePoint.position;
        }
    }

    IEnumerator RunPhase(float duration)
    {
        float currentTime = duration;

        while (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            if (uiManager != null)
            {
                uiManager.UpdateTimer(Mathf.CeilToInt(currentTime));
            }

            yield return null;
        }
    }
}