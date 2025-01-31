using UnityEngine;

public class BoxBreak : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;


    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FireBall")
        {
            boxCollider.enabled = false;
        }
    }
}
