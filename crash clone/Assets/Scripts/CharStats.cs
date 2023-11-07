using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharStats : MonoBehaviour
{
    // Life count
    public int Lives = 3;
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
