using UnityEngine;

public class HorizontalGegner : MonoBehaviour
{
    // wenn kein Schaden gewünscht damage in unity auf 0 setzen
    [SerializeField] private float damage;
    [SerializeField] private float speed;
    [SerializeField] private float movementDistance;

    private bool movingUp = true;
    private float upperEdge;
    private float lowerEdge;

    private void Awake()
    {
        // Obere und untere Grenze definieren
        upperEdge = transform.position.y + movementDistance;
        lowerEdge = transform.position.y - movementDistance;
    }

    private void Update()
    {
        if (movingUp)
        {
            // So lange noch unterhalb des oberen Grenzwerts -> nach oben bewegen
            if (transform.position.y < upperEdge)
            {
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y + speed * Time.deltaTime,
                    transform.position.z
                );
            }
            else
            {
                // Obere Grenze erreicht -> Richtung wechseln
                movingUp = false;
            }
        }
        else
        {
            // So lange oberhalb des unteren Grenzwerts -> nach unten bewegen
            if (transform.position.y > lowerEdge)
            {
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y - speed * Time.deltaTime,
                    transform.position.z
                );
            }
            else
            {
                // Untere Grenze erreicht -> Richtung wechseln
                movingUp = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
