using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Game object input
    public Transform target;
    // Smoothing for cam
    public float smoothRate = 5.0f;

    private void Update()
    {
        // Get camera pos
        Vector3 currentPosition = transform.position;
        // Calculate target pos
        Vector3 targetPosition = new Vector3(currentPosition.x, target.position.y + 2, target.position.z - 5);
        // Move camera to target pos
        transform.position = Vector3.Lerp(currentPosition, targetPosition, smoothRate * Time.deltaTime);
    }
}