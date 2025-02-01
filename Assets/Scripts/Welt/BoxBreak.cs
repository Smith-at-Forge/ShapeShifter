using UnityEngine;

public class BoxBreak : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;
    private Animator anim;


    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FireBall")
        {
            boxCollider.enabled = false;
            //anim.SetTrigger("BoxBreak");
            gameObject.SetActive(false);
        }
    }
}
