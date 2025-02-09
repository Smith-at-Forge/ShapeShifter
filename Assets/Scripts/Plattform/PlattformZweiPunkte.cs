using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlattformZweiPunkte : MonoBehaviour
{
    [SerializeField] Transform pos1;
    [SerializeField] Transform pos2;
    [SerializeField] float speedPlattform;
    Vector3 zielPunkt;


    PlayerMovement playerMovement;
    public Rigidbody2D rb;
    Vector3 moveDirection;

    private void Awake()
    {
        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        zielPunkt = pos2.position;
        DirectionCalculate();
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, pos1.position) < 0.05f)
        {
            zielPunkt = pos2.position;
            DirectionCalculate();
        }

        if (Vector2.Distance(transform.position, pos2.position) < 0.05f)
        {
            zielPunkt = pos1.position;
            DirectionCalculate();
        }

        
    }

    private void Fixedupdate()
    {
        rb.linearVelocity = moveDirection * speedPlattform;
    }

    private void DirectionCalculate()
    {
        moveDirection = (zielPunkt - transform.position).normalized;
    }


    private void OnTriggerEnter2(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerMovement.isOnPlattform = true;
            playerMovement.platformRB = rb;
        }
    }

    private void OnTriggerExit2(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerMovement.isOnPlattform = false;
            
        }
    }







}
