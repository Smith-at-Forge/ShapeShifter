using UnityEngine;

public class SpielerRespawn : MonoBehaviour
{
    // [SerializeField] private AudioClip checkpointSound;
    private Health playerHealth;
    private Transform currentCheckpoint;
    private UIManager uiManager;

    [SerializeField] private Transform spawnPoint;
    private bool check = false;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
        uiManager = FindAnyObjectByType<UIManager>();
    }

    public void CheckRespawn()
    {
        if (check == false)
        {
            uiManager.GameOver();
            return;
        }

        transform.position = currentCheckpoint.position;
        playerHealth.Respawn();
        

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
