using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            EnemyHealth health = GetComponent<EnemyHealth>();

            if (health != null)
            {
                health.TakeDamage(1);
            }

            Destroy(other.gameObject);
        }
    }
}