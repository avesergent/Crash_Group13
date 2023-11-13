using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAttack : MonoBehaviour
{
    public bool isSpinning = false;
    private float attackDuration = 1.0f;
    private float attackCooldown = 1.5f;
    private float lastAttackTime = 0f;
    public CharStats CharStats;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.time - lastAttackTime >= attackCooldown)
        {
            StartAttack();
        }

        if (isSpinning && Time.time - lastAttackTime >= attackDuration)
        {
            StopAttack();
        }

        // Change player's color based on attack state
        if (isSpinning)
        {
            SetPlayerColor(Color.red);
        }
        else
        {
            SetPlayerColor(Color.green);
        }
    }
    ///<summary>
    ///Starts player attack state
    /// </summary>
    private void StartAttack()
    {
        isSpinning = true;
        lastAttackTime = Time.time;
        //Add enemy destroying
    }
    ///<summary>
    ///Ends player attack state
    /// </summary>
    private void StopAttack()
    {
        isSpinning = false;
    }
    ///<summary>
    ///Changes player color
    /// </summary>
    private void SetPlayerColor(Color color)
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = color;
    }
}
