using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float jumpForce = 5;

    [SerializeField]
    float moveSpeed = 5;

    [SerializeField]
    LayerMask groundLayer;

    float hInput;
    float currentYVelocity;
    bool jump = false;
    bool canJump = false;

    Animator impAnim;
    public SpriteRenderer impSprite;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        impAnim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");

        impAnim.SetFloat("Speed", Mathf.Abs(hInput));

        impSprite.flipX = hInput < 0;

        jump = Input.GetButtonDown("Jump");

        canJump = false;

        RaycastHit2D hit;

        hit = Physics2D.Raycast(transform.position, Vector2.down, 1, groundLayer);
        if (hit.transform != null)
        {
            canJump = true;
        }
        if (jump && canJump)
        {
            float currentXVelocity = rb.velocity.x;
            rb.velocity = new Vector2(currentXVelocity, jumpForce);
        }
    }
    public void FixedUpdate()
    {
        currentYVelocity = rb.velocity.y;

        rb.velocity = new Vector2(hInput * moveSpeed, currentYVelocity);
    }
}
