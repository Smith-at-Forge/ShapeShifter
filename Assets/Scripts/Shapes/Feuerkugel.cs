using UnityEngine;

public class Feuerkugel : MonoBehaviour //, IShape
{
   
    public float fieldOfInpact;
    public float force;
    public LayerMask LayerToHit;

    public GameObject BurnEffect;
    public GameObject ExplosionEffect;

    void Start()
    {
        
    }

    
    void Update()
    {
        Burn();
        if(Input.GetKeyUp(KeyCode.F))
        {
            Explode();
        }

    }
    //public void Jump()
    //{
    //    throw new System.NotImplementedException();
    //}

    public void Explode()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfInpact, LayerToHit);
        foreach (Collider2D obj in objects)
        {
            Vector2 direction  = obj.transform.position - transform.position;
            obj.GetComponent<Rigidbody2D>().AddForce(direction*force);
            GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, obj.transform.position, Quaternion.identity);
            Destroy(ExplosionEffectIns, 2f);
            Destroy(obj.gameObject);
        }
        //GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
        //Destroy(ExplosionEffectIns, 10);
        //animator.SetBool("isExploding", true);
        
    }

    public void Burn()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfInpact, LayerToHit);
        foreach (Collider2D obj in objects)
        {
            //Vector2 direction  = obj.transform.position - transform.position;
            //obj.GetComponent<Rigidbody2D>().AddForce(direction*force);
            GameObject BurnEffectIns = Instantiate(BurnEffect, obj.transform.position, Quaternion.identity);
            Destroy(BurnEffectIns, 2f);
            Destroy(obj.gameObject, 2f);

        }
        
        //Destroy(BurnEffectIns, 2f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, fieldOfInpact);
    }

    //public void SecondaryAbility()
    //{
    //    throw new System.NotImplementedException();
    //}


}
