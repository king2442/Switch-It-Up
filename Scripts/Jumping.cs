using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    bool isGrounded = true;
   // private int JumpCount = 2; ( If jump needs to be limited)
    private int maxJump = 2;
    public float JumpSpeed;
    public float Jump2Speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || maxJump>0))
        {
            isGrounded = false;
            //JumpCount--;
            if (maxJump == 1)
                rb.velocity += Vector3.up * (JumpSpeed * Jump2Speed);
            else
                rb.velocity += Vector3.up * JumpSpeed;
            maxJump--;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
            maxJump = 2;
        }
    }
}
