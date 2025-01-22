using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    private int currentPoint;

    public float moveSpeed;

    public float timeAtPoints;
    private float waitCounter;
    private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(Transform t in patrolPoints)
        {
            t.SetParent(null);
        }
        waitCounter = timeAtPoints;
        animator = GetComponent<Animator>();
        animator.SetBool("isMoving", true);
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, moveSpeed*Time.deltaTime);
        if (Vector3.Distance(transform.position, patrolPoints[currentPoint].position) < 0.001f)
        {
            waitCounter -= Time.deltaTime;
            animator.SetBool("isMoving", false);

            if (waitCounter <= 0)
            {
                currentPoint++;
                if (currentPoint >= patrolPoints.Length)
                {
                    currentPoint = 0;
                }
                waitCounter = timeAtPoints;
                animator.SetBool("isMoving", true);
                if(transform.position.x < patrolPoints[currentPoint].position.x)
                {
                    transform.localScale = new Vector3(-1f,1f, 1f);

                }
                else
                {
                    transform.localScale = Vector3.one;
                }
            }
        }
    }
}
