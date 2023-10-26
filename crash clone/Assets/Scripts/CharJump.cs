using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharJump : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
