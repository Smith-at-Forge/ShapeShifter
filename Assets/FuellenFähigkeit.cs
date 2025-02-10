using UnityEngine;

public class FuellenFähigkeit : MonoBehaviour
{
    public GameObject fliessendeFluessig;
    
    void Start()
    {
        //currentWolke = Instantiate(ShapeManager.instance.wolke, transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Flow();
        }
    }

    public void Flow()
    {
        if (ShapeManager.instance.isFluessigTimerActive)
        {
            SetFlow();
        }
    }
    void SetFlow()
    {
        if (ShapeManager.instance.currentShape != null)
        {
            Destroy(ShapeManager.instance.currentShape); // Alte Form entfernen
        }
        ShapeManager.instance.currentShape = Instantiate(fliessendeFluessig, ShapeManager.instance.currentShape.transform.position, Quaternion.identity); // Neue Form instanziieren
        Camera.main.GetComponent<CameraController>().Follow(ShapeManager.instance.currentShape);

    }
}
