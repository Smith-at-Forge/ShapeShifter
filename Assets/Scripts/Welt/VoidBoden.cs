using UnityEngine;

public class VoidBoden : MonoBehaviour
{
    [SerializeField] private float damage;
    public SpielerRespawn spielerRespawn;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //collision.GetComponent<Health>().TakeDamage(damage);
            spielerRespawn.CheckRespawn();
        }
    }
}
