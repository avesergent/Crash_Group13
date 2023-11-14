using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleport : MonoBehaviour
{
    // Reference to the spawn point
    public Transform SpawnPoint;
    // Reference to the alternative spawn point
    public Transform holdSpawnPoint;
    public Transform holdSpawnPoint2;
    public Transform holdSpawnPoint3;
    private float LevelCount = 1;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the specified portal tag
        if (other.gameObject.tag == "Portal")
        {
            if (LevelCount == 1)
            {
                // Teleport the spawn point to the new location
                TeleportSpawnPoint(holdSpawnPoint);

                // Teleport the player to the alternative spawn point's position
                TeleportPlayer(SpawnPoint);
                LevelCount++;
            }
            if (LevelCount == 2)
            {
                // Teleport the spawn point to the new location
                TeleportSpawnPoint(holdSpawnPoint2);

                // Teleport the player to the alternative spawn point's position
                TeleportPlayer(SpawnPoint);
                LevelCount++;
            }
            if (LevelCount == 3)
            {
                // Teleport the spawn point to the new location
                TeleportSpawnPoint(holdSpawnPoint3);

                // Teleport the player to the alternative spawn point's position
                TeleportPlayer(SpawnPoint);
                LevelCount++;
            }

        }

    }

    private void TeleportSpawnPoint(Transform holdSpawnPoint)
    {
        // Move the spawn point to the new location
        SpawnPoint.position = holdSpawnPoint.position;
    }

    private void TeleportPlayer(Transform SpawnPoint)
    {
        // Move the player to the specified position
        transform.position = SpawnPoint.position;
    }
}
