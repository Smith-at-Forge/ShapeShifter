using UnityEngine;

public class Flüssigkeit : MonoBehaviour //, IShape
{
    public float fieldOfInpact;
    public float force;
    public LayerMask LayerToHit;

    public GameObject LoeschEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FeuerLöschen();
    }
    public void FeuerLöschen()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfInpact, LayerToHit);
        foreach (Collider2D obj in objects)
        {
            //Vector2 direction  = obj.transform.position - transform.position;
            //obj.GetComponent<Rigidbody2D>().AddForce(direction*force);
            GameObject LoeschEffectIns = Instantiate(LoeschEffect, transform.position, Quaternion.identity);
            Destroy(LoeschEffectIns, 2f);
            Destroy(obj.gameObject, 2f);

        }
    }

    public void SecondaryAbility()
    {
        throw new System.NotImplementedException();
    }

    
}
