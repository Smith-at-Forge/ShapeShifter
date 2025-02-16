using UnityEngine;

public class BatAI : MonoBehaviour
{
    public float wakeUpDistance = 5f;
    public Transform player; // Hier den Spieler per Inspector zuweisen

    private Animator animator;
    private EnemyPatrol enemyPatrol;

    void Start()
    {
        animator = GetComponent<Animator>();
        enemyPatrol = GetComponent<EnemyPatrol>();
        enemyPatrol.enabled = false; // EnemyPatrol erst später aktivieren
    }

    void Update()
    {
        if (!enemyPatrol.enabled)
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= wakeUpDistance)
            {
                // Aufwach-Animation starten (entweder über Trigger oder direkt abspielen)
                animator.SetTrigger("WakeUp"); // z.B. Trigger im Animator

                // EnemyPatrol aktivieren, damit die Fledermaus beginnt zu patrouillieren
                enemyPatrol.enabled = true;
            }
        }
    }
}
