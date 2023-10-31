using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // The game object to follow
    public Transform target;
    // Smoothing factor for camera movement
    public float smoothRate = 5.0f;

    private void Update()
    {
        // Get the current camera position
        Vector3 currentPosition = transform.position;
        // Calculate the target position with the same X and Y coordinates as the camera
        Vector3 targetPosition = new Vector3(currentPosition.x, target.position.y + 2, target.position.z - 5);
        // Smoothly move the camera to the target position
        transform.position = Vector3.Lerp(currentPosition, targetPosition, smoothRate * Time.deltaTime);
    }
}
