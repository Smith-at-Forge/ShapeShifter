using UnityEngine;

public class PlantShooter : MonoBehaviour
{
    [Header("Shoot Settings")]
    [SerializeField] private GameObject feuerBallPrefab; // Hier weist du dein "FeuerBall"-Prefab zu
    [SerializeField] private float shootInterval = 5f;    // Schießt alle 5 Sekunden
    [SerializeField] private float shootDirection = -1f;   // 1 = rechts, -1 = links

    [Header("References")]
    [SerializeField] private Transform shootPoint;        // Position, wo das Projektil spawnt

    private void Start()
    {
        // Ruft die Shoot()-Methode alle shootInterval Sekunden auf
        InvokeRepeating(nameof(Shoot), shootInterval, shootInterval);
    }

    private void Shoot()
    {
        // Erzeugt eine Instanz vom FeuerBall-Prefab an der Position von shootPoint
        GameObject newFeuerBall = Instantiate(feuerBallPrefab, shootPoint.position, Quaternion.identity);
        
        // Setzt die Richtung für das Projektil
        Projektil proj = newFeuerBall.GetComponent<Projektil>();
        if (proj != null)
        {
            proj.SetDirection(shootDirection);
        }
    }
    }

