using UnityEngine;

public class SpielerRespawn : MonoBehaviour
{
    // [SerializeField] private AudioClip checkpointSound;
    private Health playerHealth;
    private Transform currentCheckpoint;
    [SerializeField] private Transform spawnPoint;
    private bool check = false;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
    }

    public void CheckRespawn()
    {
        if (check == true)
        {
            transform.position = currentCheckpoint.position; // Bewegt Spieler zu Checkpoint zurueck
            playerHealth.Respawn(); // Leben & Animation zuruecksetzen
        }
        else
        {
            transform.position = spawnPoint.position;
        }
        

        // Kamera zur�ckbewegen falls Raumkamera aktiv und nicht Spielerverfolgung
        // Camera.main.GetComponent<CameraController>().MoveToNewRoom(currentCheckpoint.parent);

    }

    // Checkpoints aktivieren
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Checkpoint")
        {
            currentCheckpoint = collision.transform; // Checkpoint speichern
            collision.GetComponent<Collider2D>().enabled = false;
            collision.GetComponent<Animator>().SetTrigger("erscheinen");
            check = true;
        }
    }
}
