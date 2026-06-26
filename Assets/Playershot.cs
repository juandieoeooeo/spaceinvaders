using UnityEngine;
using UnityEngine.InputSystem;

public class Playershot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform aimTarget;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 direction = aimTarget.position - firePoint.position;

            GameObject bullet = Instantiate(
                bulletPrefab,
                firePoint.position,
                Quaternion.identity
            );

            bullet.GetComponent<Bullet>().SetDirection(direction);
        }
    }
}