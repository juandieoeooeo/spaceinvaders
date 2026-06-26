using UnityEngine;

public class BossShoot : MonoBehaviour
{
    public GameObject bossBulletPrefab;
    public Transform shootPoint;

    public float shootInterval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(Shoot), 2f, shootInterval);
    }

    void Shoot()
    {
        Instantiate(
            bossBulletPrefab,
            shootPoint.position,
            shootPoint.rotation
        );
    }
}