using UnityEngine;

public class SpielerRespawn : MonoBehaviour
{
    // [SerializeField] private AudioClip checkpointSound;
    [SerializeField, Range(0,1)] public int spielerRespawnAnazahl;
    //[SerializeField] private GameObject dragonWarrior;
    private Health playerHealth;
    private Transform currentCheckpoint;
    private UIManager uiManager;

    //[SerializeField] private Transform spawnPoint;
    private bool check = false;

    private void Awake()
    {
        playerHealth = GetComponent<Health>();
        uiManager = FindAnyObjectByType<UIManager>();
    }

    private void Update()
    {
        if (playerHealth.currentHealth == 0)
            CheckRespawn();
    }

    public void CheckRespawn()
    {
        if (spielerRespawnAnazahl == 0)
        {
            uiManager.GameOver();
            //return;
        }

        spielerRespawnAnazahl -= 1;
        if (check == true)
        {
            transform.position = currentCheckpoint.position;
            playerHealth.Respawn();
        }
        else
        {
            //transform.position = ShapeManager.position;
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
            spielerRespawnAnazahl = 1;
        }
    }
}
