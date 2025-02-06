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
    //private float AbstossenZeit = 2f;
    //private Collider2D storedCollision;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<getCoins>(out getCoins coin))
        {
            //storedCollision = collision;
            coin.SetTarget(transform.position);
        }
    }

    public void Anziehen()
    {
        
        
            //if (storedCollision.gameObject.TryGetComponent<getCoins>(out getCoins coin))
            //{
                
            //    coin.SetTarget(transform.position);
            //}
            
        
        //isAttracting = true;
        //Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfAttract, LayerToAttract);
        //foreach (Collider2D obj in objects)
        //{
        //    getCoins.instance.SetTarget(transform.position);
        //}


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

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Abstossen();
        }

        //if (storedCollision != null && Input.GetKeyDown(KeyCode.F))
        //{
        //    if (storedCollision.gameObject.TryGetComponent<getCoins>(out getCoins coin))
        //    {

        //        coin.SetTarget(transform.position);
        //    }
        //}
        //storedCollision = null;
        ////{
        //    if(isAttracting)
        //    { 
        //        Abstossen();
        //        isAttracting = false ;

        //    }
        //    else
        //    {
        //        Anziehen();
        //    }
        //}
    }

    

}
