using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    public GameObject defaultShape;
    public GameObject wolke;
    public GameObject fluessig;
    public GameObject feuerKugel;
    public GameObject kristall;
    public GameObject magnet;

    private GameObject currentShape;
    [SerializeField] private bool isFluessigFreigeschaltet = false;
    [SerializeField] private bool isFeuerKugelFreigeschaltet = false ;
    [SerializeField] private bool isKristallFreigeschaltet = false;
    [SerializeField] private bool isMagnetFreigeschaltet = false;
    [SerializeField] private float wolkenTimerValue = 10f;
    private float wolkenTimer; // Countdown für Wolken-Form
    private bool isWolkenTimerActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Start mit DefaultShape
        currentShape = Instantiate(defaultShape, transform.position, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {

        ChangeShape();

        // Wolken countdown
        if (isWolkenTimerActive)
        {
            wolkenTimer -= Time.deltaTime;
            if (wolkenTimer <= 0f)
            {
                wolkenTimer = 0f;
                isWolkenTimerActive = false;
                SetShape(defaultShape); // Zurück zum defaultShape
            }
        }
    }
    void ChangeShape()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && !isWolkenTimerActive) // "1"-Taste auf der Haupttastatur (nicht das numerische Tastenfeld).
        {
            StartWolkenForm();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
       
            if (isFluessigFreigeschaltet)
            {
                SetShape(fluessig);
            }
            else
            {
                Debug.Log("Die Form Flüssig is nicht freigeschaltet!");
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (isFeuerKugelFreigeschaltet)
            {

                SetShape(feuerKugel);
            }
            else
            {
                Debug.Log("Die Form FeuerKugel is nicht freigeschaltet!");
            }

        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (isKristallFreigeschaltet)
            {
                 SetShape(kristall);
            }
            else
            {
                 Debug.Log("Die Form Kristall is nicht freigeschaltet!");
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (isMagnetFreigeschaltet)
            {
                SetShape(magnet);
            }
            else
            {
                Debug.Log("Die Form Magnet is nicht freigeschaltet!");
            }
        }

    }

    void StartWolkenForm()
    {
        SetShape(wolke);
        isWolkenTimerActive = true;
        wolkenTimer = wolkenTimerValue; // 10 Sekunden Timer für Form Wolke
    }

    void SetShape(GameObject newShapePrefarb)
    {
        if (currentShape != null)
        {
            Destroy(currentShape); // Alte Form entfernen
        }
        currentShape = Instantiate(newShapePrefarb, currentShape.transform.position,Quaternion.identity); // Neue Form instanziieren
    }

    #region Methoden für die Freischaltung der Formen
    public void FreischaltungFluessig()
    {
        isFluessigFreigeschaltet = true;
    }
    public void FreischaltungFeuerKugel()
    {
        isFeuerKugelFreigeschaltet = true;
    }
    public void FreischaltungKristall()
    {
        isKristallFreigeschaltet = true;
    }
    public void FreischaltungMagnet()
    {
        isMagnetFreigeschaltet = true;
    }
    #endregion
}
