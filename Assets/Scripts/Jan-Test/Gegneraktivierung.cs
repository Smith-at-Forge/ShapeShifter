using UnityEngine;

public class GegnerAktivierung : MonoBehaviour
{
    public float aktivierungsDistanz = 5f; // Distanz, bei der die Fledermaus aktiv wird
    private Animator animator;
	public Transform player;
	public EnemyPatrol enemyPatrolScript;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
		enemyPatrolScript = GetComponent<EnemyPatrol>();
		
		if (enemyPatrolScript != null)
        {
            enemyPatrolScript.enabled = false;
        }
    }

    void Update()
    {
		
        // Überprüfung, ob der Spieler in der Nähe ist
        if (player != null && Vector3.Distance(transform.position, player.position) < aktivierungsDistanz)
        {
		// Aktiviere EnemyPatrol, falls es noch nicht aktiv ist
            if (enemyPatrolScript != null && !enemyPatrolScript.enabled)
            {
                enemyPatrolScript.enabled = true;
                if (animator != null && !animator.enabled)
                {
                    animator.enabled = true;
                }
            }
        }
    }
}