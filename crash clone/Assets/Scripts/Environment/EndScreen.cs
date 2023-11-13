using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
  /// <summary>
  /// quits the game
  /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// changes the scene to a scene with a matching index
    /// </summary>
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
