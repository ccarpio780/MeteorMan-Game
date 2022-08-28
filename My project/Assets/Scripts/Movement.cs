using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxSpeed = 10.0f;
    public float maxHeight = 5.0f;
    int jumpCounter = 0;
    public Transform groundCheck;
    public LayerMask groundLayer;
    bool onGround;

    AudioSource jumpSound;
    Animator anim;
    Rigidbody2D rb;
    SpriteRenderer sp;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Vertical");

        anim.SetFloat("Speed", Mathf.Abs(move));
        rb.velocity = new Vector2(move * maxSpeed, rb.velocity.y);

        onGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        flipDirection();

        if (Input.GetKeyDown("space"))
        {
            if (onGround)
            {
                jumpCounter++;
                Jump();
                Debug.Log("JumpCount: " + jumpCounter);
                onGround = false;
            }
            else if (jumpCounter == 1)
            {
                Jump();
                jumpCounter++;
                onGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
                Debug.Log("JumpCount: " + jumpCounter);
            }
        }
        if (jumpCounter >= 2 && onGround)
        {
            jumpCounter = 0;
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * maxHeight;
        jumpSound.Play();
        

    }

    void flipDirection() {
            if (rb.velocity.x <-0.1f) {
                sp.flipX = false;
            }
            else if (rb.velocity.x >0.1f) {
                sp.flipX = true;
            }
    }
}
