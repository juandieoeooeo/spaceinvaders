using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    private Vector3 direction;

    public void SetDirection(Vector3 newDirection)
    {
        direction = newDirection.normalized;
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}