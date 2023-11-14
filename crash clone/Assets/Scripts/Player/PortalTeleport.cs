using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalTeleport : MonoBehaviour
{
    // Reference to the original spawn
    public Transform originalSpawnPoint;
    // Reference to the alternative spawns
    public Transform holdSpawnPoint1;
    public Transform holdSpawnPoint2;
    public Transform holdSpawnPoint3;
    //Counts levels to teleport the player properly
    private float LevelCount = 1;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the specified portal tag
        if (other.gameObject.tag == "Portal")
        {

            if (LevelCount == 1)
            {
                // Teleport the spawn point to the new location
                TeleportSpawnPoint1(holdSpawnPoint1);

                // Teleport the player to the alternative spawn point's position
                TeleportPlayer(originalSpawnPoint);
                LevelCount++;
                print(LevelCount);
            }

            else if(LevelCount == 2)
            {
                // Teleport the spawn point to the new location
                TeleportSpawnPoint2(holdSpawnPoint2);

                // Teleport the player to the alternative spawn point's position
                TeleportPlayer(originalSpawnPoint);
                LevelCount++;
            }

            else if(LevelCount == 3)
            {
                // Teleport the spawn point to the new location
                TeleportSpawnPoint3(holdSpawnPoint3);

                // Teleport the player to the alternative spawn point's position
                TeleportPlayer(originalSpawnPoint);
                LevelCount++;
            }

            else if (LevelCount == 4)
            {
                SceneManager.LoadScene(2);
                LevelCount = 1;
            }

            else
            {

            }
        }

    }

    private void TeleportSpawnPoint1(Transform holdSpawnPoint1)
    {
        // Move the spawn point to the new location
        originalSpawnPoint.position = holdSpawnPoint1.position;
    }
    private void TeleportSpawnPoint2(Transform holdSpawnPoint2)
    {
        // Move the spawn point to the new location
        originalSpawnPoint.position = holdSpawnPoint2.position;
    }
    private void TeleportSpawnPoint3(Transform holdSpawnPoint3)
    {
        // Move the spawn point to the new location
        originalSpawnPoint.position = holdSpawnPoint3.position;
    }

    private void TeleportPlayer(Transform SpawnPoint)
    {
        // Move the player to the specified position
        transform.position = SpawnPoint.position;
    }
}
