using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthToAdd;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerHealthController.instance.AddHealth(healthToAdd);

            Destroy(gameObject);
        }
    }
}
