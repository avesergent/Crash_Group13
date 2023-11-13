using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegEnemy : MonoBehaviour
{
    public GameObject leftPoint;
    public GameObject rightPoint;
    private Vector3 leftPos;
    private Vector3 rightPos;
    public int speed;
    public bool goingLeft;
    private string spawnPointName = "SpawnPoint";
    // Calls charstats for use of public functions
    public CharStats CharStats;
    public CharAttack CharAttack;
    // Start is called before the first frame update
    void Start()
    {
        leftPos = leftPoint.transform.position;
        rightPos = rightPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    ///<summary>
    ///Moves the enemy from point to point
    /// </summary>
    private void Move()
    {
        if(goingLeft)
        {
            if(transform.position.x <= leftPos.x)
            {
                goingLeft = false;
            }
            else
            {
                transform.position += Vector3.left * Time.deltaTime * speed;
            }
        }
        else
        {
            if(transform.position.x >= rightPos.x)
            {
                goingLeft=true;
            }
            else
            {
                transform.position += Vector3.right * Time.deltaTime * speed;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (CharAttack.isSpinning == true)
            {
                Destroy(gameObject);
            }
            else
            {
                // Check if the player is above enemy
                Vector3 playerPosition = other.transform.position;
                Vector3 enemyPosition = transform.position;

                if (playerPosition.y > enemyPosition.y + 1.12)
                {
                    Destroy(gameObject);
                }
                else
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
    }
}
