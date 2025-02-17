using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image lebensAnzeigeGesamt;
    [SerializeField] private Image lebenAnzeigeAktuell;

    //public Health health;

    private void Start()
    {
        lebensAnzeigeGesamt.fillAmount = playerHealth.currentHealth / 10;
        
    }
    private void Update()
    {
        lebenAnzeigeAktuell.fillAmount = playerHealth.currentHealth / 10;
        Debug.Log("Leben aus LebensAnzeige.cs: " + playerHealth.currentHealth);
    }
}