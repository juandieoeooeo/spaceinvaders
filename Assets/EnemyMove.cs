using UnityEngine;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 movement = transform.right * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }
}