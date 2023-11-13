using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{

    public TMP_Text scoreText;
    public TMP_Text livesText;
    public CharStats CharStats;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Total Wumpa Fruit: " + CharStats.totalWumpaFruit;
        livesText.text = "Lives: " + CharStats.Lives; 
    }
}
