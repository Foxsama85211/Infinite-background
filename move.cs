using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]

public class move : MonoBehaviour
{
    public float jump = 15f;
    private Rigidbody2D rb;
private bool isGrounded;
[SerializeField] 
private Transform groundCheck;
private float groundCheckRadius = 0.2f;
[SerializeField] 
private LayerMask GroundLayer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
  

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = CheckifGrounded();
              HandleJump();
    }
private bool CheckifGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, GroundLayer);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
   private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump);
        }
    }
}