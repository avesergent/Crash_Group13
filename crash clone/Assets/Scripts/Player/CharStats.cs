using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharStats : MonoBehaviour
{

    //wumpa score
    public float totalWumpaFruit = 0f;

    //wumpafruit value
    private float wumpaPointValue = 1f;
    // Life count
    public int Lives = 3;

    public void Start()
    {


    }
    //destroys wumpa when collided with
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "WumpaFruit")
        {
            //if the object is tagged as wumpafruit
            totalWumpaFruit += wumpaPointValue;
            Destroy(other.gameObject);
        }

        //if collide with portal trigger, teleport player to next area
        //then reset start position
        if (other.gameObject.tag == "Portal")
        {
            //reset start pos to new spawnpoint
            startPosition = other.gameObject.GetComponent<Portal>().spawnPoint.transform.position;
            //bring player back to start position
            transform.position = startPosition;
        }
    }
    ///<summary>
    ///Removes a life when called upon
    ///</summary>
    public void LoseALife()
    {
        Lives--;
        if (Lives == 0)
        {
            SceneManager.LoadScene(1);
        }
        
    }
    ///<summary>
    ///Add a life when called upon
    ///</summary>
    public void AddALife()
    {
        Lives++;
    }
}
