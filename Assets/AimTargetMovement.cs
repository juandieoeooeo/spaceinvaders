using UnityEngine;
using UnityEngine.InputSystem;

public class AimTargetMovement : MonoBehaviour
{
    public Camera mainCamera;
    public Transform firePoint;
    public float distanceForward = 40f;

    void Update()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();

        Vector3 screenPoint = new Vector3(
            mousePosition.x,
            mousePosition.y,
            mainCamera.WorldToScreenPoint(firePoint.position + Vector3.left * distanceForward).z
        );

        transform.position = mainCamera.ScreenToWorldPoint(screenPoint);
    }
}