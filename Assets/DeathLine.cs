using UnityEngine;

public class DeathLine : MonoBehaviour
{
    public PlayerHealth player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("BossBullet"))
        {
            player.TakeDamage(1);
            Destroy(other.gameObject);
        }
    }
}