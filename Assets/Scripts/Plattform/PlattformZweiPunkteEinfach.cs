using UnityEngine;

public class PlattformZweiPunkteEinfach : MonoBehaviour
{
    [SerializeField] Transform pos1;
    [SerializeField] Transform pos2;
    [SerializeField] public float plattformSpeed;
    Vector3 targetPos;

    private void Start()
    {
        targetPos = pos2.position;
    }


    private void Update()
    {
        if (Vector2.Distance(transform.position,pos1.position) < 0.05f)
        {
            targetPos = pos2.position;
        }

        if (Vector2.Distance(transform.position,pos2.position) < 0.05f)
        {
            targetPos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPos, plattformSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.parent = this.transform;
        }
    }

        private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }


}
