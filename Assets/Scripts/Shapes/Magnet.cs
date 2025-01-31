using UnityEngine;

public class Magnet : MonoBehaviour /* IShape*/
{
    //public static Magnet instance;

    //private void Awake()
    //{
    //    instance = this;
    //}

    //public Transform magnet;
    //public float magnetPosX;
    //public float magnetPosY;
    //public bool attract = false;
    //void Start()
    //{

    //}

    public float fieldOfInpact;
    public float force;
    public LayerMask LayerToHit;

    public float fieldOfAttract;
    public float attracForce;
    public LayerMask LayerToAttract;

    public bool isAttracting = false;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.gameObject.TryGetComponent<getCoins>(out getCoins coin))
    //    {
    //        coin.SetTarget(transform.position);
    //    }
    //}

    public void Anziehen()
    {
        isAttracting=true;  
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfAttract, LayerToAttract);
        foreach (Collider2D obj in objects)
        {
            getCoins.instance.SetTarget(transform.position);
        }

       
    }
    public void Abstossen()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfInpact, LayerToHit);
        foreach (Collider2D obj in objects)
        {
            //Vector2 direction  = obj.transform.position - transform.position;
            //obj.GetComponent<Rigidbody2D>().AddForce(direction*force);
            Destroy(obj.gameObject);
        }
        //GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
        //Destroy(ExplosionEffectIns, 10);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(isAttracting)
            { 
                Abstossen();
                isAttracting = false ;
            }
            else
            {
                Anziehen();
            }
        }
    }

    

}
