using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotation : MonoBehaviour
{
    private float _rotSpeed = 360f;     // Test
    
    public void Rotate(InputAction.CallbackContext context)
    {
        Debug.Log("Yo");
        
        Camera camera = Camera.main;
        Vector2 mouseScreenPosition = camera.ScreenToViewportPoint(Input.mousePosition);
        Vector2 playerScreenPosition = camera.ScreenToViewportPoint(transform.position);

        float angle = AngleBetweenPoints(mouseScreenPosition, playerScreenPosition);

        transform.rotation = Quaternion.Euler(0, 0, angle);

    }

    private float AngleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
