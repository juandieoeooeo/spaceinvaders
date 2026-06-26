using UnityEngine;

public class BossController : MonoBehaviour
{
    public Vector3 battlePosition;

    public float entrySpeed = 8f;
    public float moveSpeed = 5f;

    public float minY = 10f;
    public float maxY = 30f;
    public float minZ = -120f;
    public float maxZ = -70f;

    public Vector3 bossRotation = new Vector3(0f, 90f, 0f);

    private bool entered = false;
    private Vector3 targetPosition;

    void Start()
    {
        transform.rotation = Quaternion.Euler(bossRotation);
        targetPosition = battlePosition;
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(bossRotation);

        if (!entered)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                battlePosition,
                entrySpeed * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, battlePosition) < 0.1f)
            {
                entered = true;
                PickNewTarget();
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                moveSpeed * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, targetPosition) < 0.5f)
            {
                PickNewTarget();
            }
        }
    }

    void PickNewTarget()
    {
        targetPosition = new Vector3(
            battlePosition.x,
            Random.Range(minY, maxY),
            Random.Range(minZ, maxZ)
        );
    }
}