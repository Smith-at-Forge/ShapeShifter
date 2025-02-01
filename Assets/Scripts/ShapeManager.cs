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
    [SerializeField] private float timerValue = 10f;
    private float timer; // Countdown f�r die Form
    private bool isWolkenTimerActive = false;
    private bool isFluessigTimerActive = false;
    private bool isFeuerKugelTimerActive = false;
    private bool isKristallTimerActive = false;
    private bool isMagnetTimerActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Start mit DefaultShape
        currentShape = Instantiate(defaultShape, transform.position, Quaternion.identity);
        Camera.main.GetComponent<CameraController>().Follow(currentShape);
        
    }

    // Update is called once per frame
    void Update()
    {

        ChangeShape();

        // Wolken countdown
        if (isWolkenTimerActive)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer = 0f;
                isWolkenTimerActive = false;
                SetShape(defaultShape); // Zur�ck zum defaultShape
            }
        }
        if (isFluessigTimerActive)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer = 0f;
                isFluessigTimerActive = false;
                SetShape(defaultShape); // Zur�ck zum defaultShape
            }
        }
        if (isFeuerKugelTimerActive)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer = 0f;
                isFeuerKugelTimerActive = false;
                SetShape(defaultShape); // Zur�ck zum defaultShape
            }
        }
        if (isKristallTimerActive)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer = 0f;
                isKristallTimerActive = false;
                SetShape(defaultShape); // Zur�ck zum defaultShape
            }
        }
        if (isMagnetTimerActive)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                timer = 0f;
                isMagnetTimerActive = false;
                SetShape(defaultShape); // Zur�ck zum defaultShape
            }
        }
    }
    void ChangeShape()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && !isWolkenTimerActive) // "1"-Taste auf der Haupttastatur (nicht das numerische Tastenfeld).
        {
            StartWolkenForm();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && !isFluessigTimerActive)
        {
       
            if (isFluessigFreigeschaltet)
            {
                StartFluessigForm();
            }
            else
            {
                Debug.Log("Die Form Fl�ssig is nicht freigeschaltet!");
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && !isFeuerKugelTimerActive)
        {
            if (isFeuerKugelFreigeschaltet)
            {

                StartFeuerKugelForm();
            }
            else
            {
                Debug.Log("Die Form FeuerKugel is nicht freigeschaltet!");
            }

        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && !isKristallTimerActive)
        {
            if (isKristallFreigeschaltet)
            {
                 StartKristallForm();
            }
            else
            {
                 Debug.Log("Die Form Kristall is nicht freigeschaltet!");
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) && !isMagnetTimerActive)
        {
            if (isMagnetFreigeschaltet)
            {
                StartMagnetForm();
            }
            else
            {
                Debug.Log("Die Form Magnet is nicht freigeschaltet!");
            }
        }

    }

    void SetShape(GameObject newShapePrefarb)
    {
        if (currentShape != null)
        {
            Destroy(currentShape); // Alte Form entfernen
        }
        currentShape = Instantiate(newShapePrefarb, currentShape.transform.position, Quaternion.identity); // Neue Form instanziieren
        Camera.main.GetComponent<CameraController>().Follow(currentShape);
    }

    void StartWolkenForm()
    {
        SetShape(wolke);
        isWolkenTimerActive = true;
        timer = timerValue; // 10 Sekunden Timer f�r Form Wolke
    }
    void StartFluessigForm()
    {
        SetShape(fluessig);
        isFluessigTimerActive = true;
        timer = timerValue; // 10 Sekunden Timer f�r Form Wolke
    }
    void StartFeuerKugelForm()
    {
        SetShape(feuerKugel);
        isFeuerKugelTimerActive = true;
        timer = timerValue; // 10 Sekunden Timer f�r Form Wolke
    }
    void StartKristallForm()
    {
        SetShape(kristall);
        isKristallTimerActive = true;
        timer = timerValue; // 10 Sekunden Timer f�r Form Wolke
    }
    void StartMagnetForm()
    {
        SetShape(magnet);
        isMagnetTimerActive = true;
        timer = timerValue; // 10 Sekunden Timer f�r Form Wolke
    }



    #region Methoden f�r die Freischaltung der Formen
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
