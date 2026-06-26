using UnityEngine;
using UnityEngine;

public class BossWin : MonoBehaviour
{
    private bool bossFightStarted = false;

    public void StartBossFight()
    {
        bossFightStarted = true;
        Debug.Log("Boss fight started");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Boss tocó: " + other.name + " | Tag: " + other.tag);
    }

    private void OnDestroy()
    {
        if (!Application.isPlaying) return;

        Debug.Log("Boss destruido");

        if (!bossFightStarted) return;

        Debug.Log("YOU WIN");
        Time.timeScale = 0f;
    }
}