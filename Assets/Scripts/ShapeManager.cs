using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    public GameObject defaultShape;
    public GameObject wolke;
    public GameObject flüssigkeit;
    public GameObject feuerKugel;
    public GameObject kristall;
    public GameObject magnet;

    private GameObject currentShape;
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
    }

    void ChangeShape()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) // "1"-Taste auf der Haupttastatur (nicht das numerische Tastenfeld).
        {
            SetShape(wolke);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetShape(flüssigkeit);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetShape(feuerKugel);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetShape(kristall);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SetShape(magnet);
        }

    }

    void SetShape(GameObject newShapePrefarb)
    {
        if (currentShape != null)
        {
            Destroy(currentShape); // Alte Form entfernen
        }
        currentShape = Instantiate(newShapePrefarb, currentShape.transform.position,Quaternion.identity); // Neue Form instanziieren
    }
}
