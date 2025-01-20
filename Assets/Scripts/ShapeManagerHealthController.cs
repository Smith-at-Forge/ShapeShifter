using UnityEngine;

public class ShapeManagerHealthController : MonoBehaviour
{
    #region Singleton ShapeManagerHealthController
    public static ShapeManagerHealthController instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public int currentHealth, maxHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        UIController.instance.UpdateHealthDisplay(currentHealth, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamagePlayer()
    {
        currentHealth--;

        if (currentHealth <= 0 )
        {
            currentHealth = 0;

            gameObject.SetActive( false );
        }

        UIController.instance.UpdateHealthDisplay(currentHealth, maxHealth);
    }
}
