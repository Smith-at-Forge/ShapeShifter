using UnityEngine;

public class GegnerAktivierung : MonoBehaviour
{
    public float aktivierungsDistanz = 5f; // Distanz, bei der die Fledermaus aktiv wird
    private Animator animator;
	public Transform player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Überprüfung, ob der Spieler in der Nähe ist
        if (player != null && Vector3.Distance(transform.position, player.position) < aktivierungsDistanz)
        {
            if (animator != null && !animator.enabled) 
            {
                animator.enabled = true;
            }
        }
    }
}