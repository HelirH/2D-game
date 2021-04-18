using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    public Rigidbody2D rb;
    public SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);
        if (xInput < 0)
        {
            sp.flipX = true;
        }
        else
        {
            sp.flipX = false;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Force);
        }
    }

    bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1f);
        return hit.collider != null;
    }
}
