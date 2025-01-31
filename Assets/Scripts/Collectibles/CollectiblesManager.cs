using UnityEngine;

public class CollectiblesManager : MonoBehaviour
{
    public static CollectiblesManager instance;

    private void Awake()
    {
        instance = this;
    }
    public int collectibleCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetCollectible(int amount)
    {
        collectibleCount += amount;
        if(UIController.instance != null)
        {
            UIController.instance.UpdateCollectibles(collectibleCount);
        }
    }
}
