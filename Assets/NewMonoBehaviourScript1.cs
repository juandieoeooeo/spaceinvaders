using UnityEngine;
using UnityEngine.InputSystem;

public class AimTargetMovement : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float moveY = 0f;
        float moveZ = 0f;

        if (Keyboard.current.wKey.isPressed)
            moveY = 1f;

        if (Keyboard.current.sKey.isPressed)
            moveY = -1f;

        if (Keyboard.current.aKey.isPressed)
            moveZ = -1f;

        if (Keyboard.current.dKey.isPressed)
            moveZ = 1f;

        Vector3 movement = new Vector3(0, moveY, moveZ);

        transform.position += movement * speed * Time.deltaTime;
    }
}