using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJump : MonoBehaviour
{
    public float jumpForce = 10.0f;
    private bool isJumping = false;
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
        isJumping = true;
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //Time in between
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
