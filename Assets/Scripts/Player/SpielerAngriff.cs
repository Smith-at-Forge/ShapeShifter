using UnityEngine;

public class SpielerAngriff : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform FirePoint;
    [SerializeField] private GameObject[] fireballs;

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        // Feuerball erstellen und wiederbenutzen um Performance zu verbessern
        fireballs[FindFireball()].transform.position = FirePoint.position;
        fireballs[FindFireball()].GetComponent<Projektil>().SetDirection(Mathf.Sign(transform.localScale.x));
    }

    private int FindFireball()
    {
        for (int i = 0; i < fireballs.Length; i++)
        {
            // prüfen welche Feuerbälle aktiv sind
            if (!fireballs[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
}
