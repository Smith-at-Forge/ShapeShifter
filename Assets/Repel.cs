using UnityEngine;

public class Repel : MonoBehaviour
{
    public float fieldOfInpact;
    public float force;
    public LayerMask LayerToHit;
    
    
    void Update()
    {
        Abstossen();
    }
    public void Abstossen()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfInpact, LayerToHit);
        foreach (Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;
            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);

            Destroy(obj.gameObject, 1f);

        }

    }
}
