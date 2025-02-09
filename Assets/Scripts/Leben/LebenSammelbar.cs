using UnityEngine;

public class LebenSammelbar : MonoBehaviour
{
    [SerializeField] private float healthValue;
    [SerializeField] private AudioClip sound_health_collected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().AddHealth(healthValue);
            gameObject.SetActive(false);
            SoundManager.instance.PlaySound(sound_health_collected);

        }
    }
}
