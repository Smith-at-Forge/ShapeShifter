using UnityEngine;

public class DamageTestScript : MonoBehaviour
{
    private Health health;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("Damage über DamageTestScript");
            GetComponent<Health>().TakeDamage(1);
            //health.TakeDamage(1);
        }
    }
}
