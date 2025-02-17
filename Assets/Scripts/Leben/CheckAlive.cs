using UnityEngine;

public class CheckAlive : MonoBehaviour
{
    private Health health;
    void Update()
    {
        Debug.Log("Health from CheckAlive" + health.currentHealth);
    }
}
