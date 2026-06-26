using UnityEngine;

public class EnemyMoveZigZag : MonoBehaviour
{
    public float speed = 6f;
    public float zigZagSpeed = 4f;
    public float zigZagAmount = 7f;

    private Rigidbody rb;
    private Vector3 startPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    void FixedUpdate()
    {
        // Avanza hacia el jugador
        Vector3 forward = transform.right * speed * Time.fixedDeltaTime;

        // Movimiento en zigzag
        float offset = Mathf.Sin(Time.time * zigZagSpeed) * zigZagAmount;

        Vector3 zigzag = transform.forward * offset * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + forward + zigzag);
    }
}