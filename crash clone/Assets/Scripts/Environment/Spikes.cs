using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    // Calls charstats for use of LoseALife
    public CharStats CharStats;
    private string spawnPointName = "OGSpawnPoint";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Get spawn point by name
            GameObject spawnPoint = GameObject.Find(spawnPointName);
            // Teleport the player to the spawn point position
            other.transform.position = spawnPoint.transform.position;
            // Damage Player
            CharStats.LoseALife();
        }
    }
}
