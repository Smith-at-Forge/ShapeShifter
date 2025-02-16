//using UnityEditor.Callbacks;
using UnityEngine;
//using UnityEngine.Experimental.GlobalIllumination;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    [SerializeField] private LayerMask waterLayer;
    [SerializeField] private AudioClip sound_jump;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    private float wallJumpCooldown; 
    private float horizontalInput; // Movement links/rechts
    // Wasser ueberpruefen
    public Vector2 boxSize = new Vector2(1,1);
    private PlayerWaterCheck waterCheck;

    // Plattform
    public bool isOnPlattform;
    public Rigidbody2D platformRB;
    Rigidbody2D rb;

    private void Awake()
    {
        //Grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        waterCheck = GetComponent<PlayerWaterCheck>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //Flip player when moving left-right
        if (horizontalInput > 0.01f)
            transform.localScale = Vector3.one;
            
            
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-1, 1, 1);

        //Set animator parameters
        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", isGrounded());

        //Wall jump logic
        if (wallJumpCooldown > 0.2f)
        {
            body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocity.y);

            if (onWall() && !isGrounded())
            {
                body.gravityScale = 0;
                body.linearVelocity = Vector2.zero;
            }
            else
                body.gravityScale = 7;

            if (Input.GetKey(KeyCode.Space))
                Jump();

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded() && waterCheck)
                SoundManager.instance.PlaySound(sound_jump);
        }
        else
            wallJumpCooldown += Time.deltaTime;

        // Watercheck 
        if (waterCheck != null && waterCheck.inWater())
        {
            Debug.Log("Player in Water");
        }
        else
        {
            Debug.Log("Not in Water");
        }

        // Plattform
        /*
        if (isOnPlattform)
        {
            rb.linearVelocity = new Vector2(speed + platformRB.linearVelocity.x, rb.linearVelocity.y );
        }
        else
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }
        */

    }

    private void Jump()
    {

        if (isGrounded() && !waterCheck.inWater())
        {
            body.linearVelocity = new Vector2(body.linearVelocity.x, jumpPower);
            anim.SetTrigger("jump");
            
        }
        else if (onWall() && !isGrounded())
        {
            if (horizontalInput == 0)
            {
                body.linearVelocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 10, 0);
                transform.localScale = new Vector3(-Mathf.Sign(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else
                body.linearVelocity = new Vector2(-Mathf.Sign(transform.localScale.x) * 3, 6);

            wallJumpCooldown = 0;
        }
    }


    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
        
    }
    private bool onWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, new Vector2(transform.localScale.x, 0), 0.1f, wallLayer);
        return raycastHit.collider != null;
    }
    
    public bool canAttack()
    {
        // falls Angriff beim laufen m�glich sein soll horizontalInput == 0 entfernen
        return horizontalInput == 0 && isGrounded() && !onWall();
    }
}