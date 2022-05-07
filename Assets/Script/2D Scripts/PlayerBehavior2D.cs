using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior2D : MonoBehaviour
{
    public float moveSpeed = 0f;
    public float jumpForce = 0f;
    private Animator characterAni = null;
    private Rigidbody2D rb = null;

    // Start is called before the first frame update
    void Start()
    {
        characterAni = transform.GetComponent<Animator>();
        rb = transform.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void FixedUpdate() {
        Movement();
    }

    private void Movement()
    {
        float directionX = Input.GetAxis("Horizontal");

        if(directionX  > 0)
        {
            //Player Moves Right
            characterAni.SetFloat("Movement", directionX);
            characterAni.SetBool("IsMoving", true);
            transform.GetComponent<SpriteRenderer>().flipX = false;
            rb.velocity = new Vector2(directionX * moveSpeed, rb.velocity.y);

        }
        else if(directionX < 0)
        {
            //Player Moves Left
            characterAni.SetFloat("Movement", directionX);
            characterAni.SetBool("IsMoving", true);
            transform.GetComponent<SpriteRenderer>().flipX = true;
            rb.velocity = new Vector2(directionX * moveSpeed, rb.velocity.y);
        }
        else
        {
            //Idle animation
            characterAni.SetFloat("Movement", directionX);
            characterAni.SetBool("IsMoving", false);
            transform.GetComponent<SpriteRenderer>().flipX = false;
        }
        
        if(Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

    }
}
