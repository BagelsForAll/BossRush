using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private const int V = 10;
    public CharacterController2D controller;

    public float moveSpeed = 5f;

    float dirX;
    float jumpForce = 500f;

    bool isgrounded = false;
    bool doublejumpallowed = false;

    bool isleft = false;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (rb.velocity.y == 0)
            isgrounded = true;
        else
            isgrounded = false;

        if (isgrounded)
            doublejumpallowed = true;

        if (isgrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        } else if (doublejumpallowed && Input.GetButtonDown ("Jump"))
        {
            Jump();
            doublejumpallowed = false;
        }

        if (isleft && Input.GetAxis("Horizontal") > 0)
        {
            controller.Flip();
            isleft = false;
        }

        if (!isleft && Input.GetAxis("Horizontal") < 0)
        {
            controller.Flip();
            isleft = true;
        }


        dirX = Input.GetAxis("Horizontal") * moveSpeed;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f); ;
        rb.AddForce(Vector2.up * (jumpForce/ V));
    }
}