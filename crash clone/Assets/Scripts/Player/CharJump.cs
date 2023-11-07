using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJump : MonoBehaviour
{
    // Jump Force
    public float jumpForce = 10.0f;
    // Jump State
    private bool isJumping = false;
    // Rigidbody
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            Jump();
        }
    }
    ///<summary>
    ///Launches the player up, waits _ seconds before allowing user to jump again
    ///</summary>
    private void Jump()
    {
        // Sets isJumping to true
        isJumping = true;
        // Launches player
        rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        // Time in between
        Invoke("ResetJump", 2.0f);
    }
    ///<summary>
    ///Resets isJumping to false
    ///</summary>
    private void ResetJump()
    {
        isJumping = false;
    }
}
