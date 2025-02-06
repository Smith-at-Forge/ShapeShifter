using UnityEngine;


public class Kristall: MonoBehaviour //, IShape
{
    public float fieldOfInpact;
    //public float force;
    public LayerMask LayerToHit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Unverwundbar();
        //if (Input.GetKeyDown(KeyCode.F))
        //{
            
        //}
    }

    public void Unverwundbar()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfInpact, LayerToHit);
        foreach (Collider2D obj in objects)
        {
            //Vector2 direction = obj.transform.position - transform.position;
            //obj.GetComponent<Rigidbody2D>().AddForce(direction * force);

            Destroy(obj.gameObject);

        }

    }
    //public void Jump()
    //{
    //    throw new System.NotImplementedException();
    //}

    //public void Anziehen()
    //{
    //    throw new System.NotImplementedException();
    //}

    //public void SecondaryAbility()
    //{
    //    throw new System.NotImplementedException();
    //}

}
