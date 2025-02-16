using UnityEngine;

public class Projektil : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
    private bool hit;
    private float lifetime;

    private BoxCollider2D boxCollider;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        // wenn Feuerball was beruehrt return
        if (hit) return;
        // Feuerball hat noch nicths berueht
        float movementSpeed = speed * Time.deltaTime * direction;
        transform.Translate(movementSpeed, 0, 0);

        lifetime = Time.deltaTime;
        if (lifetime > 5) gameObject.SetActive(false);
    }
    
    // �berpr�fen ob Feuerball was getroffen hat
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hit = true;
        boxCollider.enabled = false;
        anim.SetTrigger("explode");
    }

    // links / rechts schie�en | reset des Feuerballs nach hit
    public void SetDirection(float _direction)
    {
        lifetime = 0;
        direction = _direction;
        gameObject.SetActive(true);
        hit = false;
        boxCollider.enabled = true;

        // flip Feuerball wenn in falsche Richtung schaut
        float localScaleX = transform.localScale.x;
        if (Mathf.Sign(localScaleX) != _direction)
            localScaleX = -localScaleX;

        transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }


}
