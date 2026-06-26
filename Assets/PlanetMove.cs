using UnityEngine;

public class PlanetMove : MonoBehaviour
{
    public float speed = 7f;

    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}