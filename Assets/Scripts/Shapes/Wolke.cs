using UnityEngine;

public class Wolke : MonoBehaviour // IShape
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public float jumpForce;

   
   

    public Animator animator;

    void Update()
    {
        
        Move();


        if (Input.GetButtonDown("Jump"))
        {

            Jump();
        }

        Flip();

        // handle animator

        animator.SetFloat("speed", Mathf.Abs(rb.linearVelocity.x));
        //animator.SetBool("isGrounded", isGrounded);
    }

    private void Flip()
    {
        if (rb.linearVelocity.x > 0)
        {
            transform.localScale = Vector3.one;
        }
        if (rb.linearVelocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    // Movement
    private void Move()
    {
        rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rb.linearVelocity.y);
    }

    // Jump
    public void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    
}
