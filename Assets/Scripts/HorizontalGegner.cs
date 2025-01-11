using UnityEngine;

public class HorizontalGegner : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float speed;
    [SerializeField] private float movementDistance;
    private bool movingUp;
    private float upperEdge;
    private float lowerEdge;

    // Falls gewünscht, dass sich Gegner nicht bewegt -> Script Saege

    private void Awake()
    {
        upperEdge = transform.position.y - movementDistance;
        lowerEdge = transform.position.y + movementDistance;
    }

    private void Update()
    {
        if (movingUp)
        {
            if (transform.position.y > upperEdge)
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
                movingUp = false;
        }
        else
        {
            if (transform.position.y < lowerEdge)
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
                movingUp = true;

        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
