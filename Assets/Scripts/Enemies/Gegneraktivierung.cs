using UnityEngine;

public class BatAI : MonoBehaviour
{
    public float detectionRange = 100f;  // Spieler wird erkannt, wenn er innerhalb von 100 Einheiten ist.
    private Animator animator;
    private bool isActivated = false;    
    public Transform player;            // Referenz auf den Spieler.
    public EnemyPatrol patrolScript;    // Referenz auf das Patrouillen-Skript.

    void Start()
    {
        animator = GetComponent<Animator>();
        
        if (patrolScript != null)
        {
            patrolScript.enabled = false; // Deaktiviert die Patrouille zu Beginn.
        }
    }

    void Update()
    {
        if (!isActivated)
        {
            CheckForPlayer();
        }
    }

    void CheckForPlayer()
    {
        if (player != null && Vector3.Distance(transform.position, player.position) <= detectionRange)
        {
            isActivated = true;
            animator.SetTrigger("Bat-Fying"); // Startet die Flying-Animation.
            StartPatrol();
        }
    }

    void StartPatrol()
    {
        if (patrolScript != null)
        {
            patrolScript.enabled = true; // Aktiviert das Patrouillen-Skript.
        }
    }
}
