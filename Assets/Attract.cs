using UnityEngine;

public class Attract : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<getCoins>(out getCoins coin))
        {
            coin.SetTarget(transform.position);
        }
    }
}
