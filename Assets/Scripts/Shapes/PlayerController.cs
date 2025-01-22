using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float jumpForce;
    private bool isGrounded;
    public Transform groudCheckPoint;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool canDoubleJump;

    public Animator animator;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groudCheckPoint.position, groundCheckRadius, whatIsGround);

        rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal")* moveSpeed, rb.linearVelocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                Jump();
                canDoubleJump = true;
            }
            else
            {
                if(canDoubleJump)
                {
                    Jump();
                    canDoubleJump= false;
                }
            }
        }

        if(rb.linearVelocity.x > 0)
        {
            transform.localScale = Vector3.one;
        }
        if (rb.linearVelocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        // handle animator

        animator.SetFloat("speed", Mathf.Abs(rb.linearVelocity.x));
        animator.SetBool("isGrounded", isGrounded);
    }

    // Jump
    private void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }
}
