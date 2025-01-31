using UnityEngine;

public class Collector : MonoBehaviour
{
    public int amount = 1;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectible collectible = collision.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect();
        }
        if(collision.CompareTag("Player"))
        {
            if(CollectiblesManager.instance != null)
            {
                CollectiblesManager.instance.GetCollectible(amount);
            }
        }
    }
}
