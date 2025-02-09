using UnityEngine;


public class EnemyController : MonoBehaviour
{

    [SerializeField] private float damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            PlayerHealthController.instance.DamagePlayer();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }

        if (collision.CompareTag("FireBall"))
        {
            Destroy(gameObject);
        }
    }

    // FireBall zerstoert Gegner
    /*    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("FireBall"))
        {
            Destroy(gameObject);
            //FindFirstObjectByType<PlayerController>().Jump();
            //FindFirstObjectByType<DragonPlayerController>().Jump();
        }
    }
    */
}
