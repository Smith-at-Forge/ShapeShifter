using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    #region Singleton PlayerHealthController
    public static PlayerHealthController instance;

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
        //if (Input.GetKeyDown(KeyCode.A))
        //    DamagePlayer();

        //if (Input.GetKeyDown(KeyCode.S))
        //    AddHealth(1);
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

    public void AddHealth(int amountToAdd)
    {
        currentHealth += amountToAdd;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UIController.instance.UpdateHealthDisplay(currentHealth, maxHealth);
    }
}
