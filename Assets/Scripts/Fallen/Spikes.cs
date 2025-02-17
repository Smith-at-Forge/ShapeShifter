using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private AudioClip sound_spikes;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
            SoundManager.instance.PlaySound(sound_spikes);
        }
    }
}
