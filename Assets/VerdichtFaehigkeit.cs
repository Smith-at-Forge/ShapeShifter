using UnityEngine;

public class VerdichtFaehigkeit : MonoBehaviour
{
    public GameObject verdichteWolke;
    //private GameObject currentWolke;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //currentWolke = Instantiate(ShapeManager.instance.wolke, transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Compact();
        }
    }

    public void Compact()
    {
        if (ShapeManager.instance.isWolkenTimerActive)
        {
            SetCompact();
        }
    }
    void SetCompact()
    {
        if (ShapeManager.instance.currentShape != null)
        {
            Destroy(ShapeManager.instance.currentShape); // Alte Form entfernen
        }
        ShapeManager.instance.currentShape = Instantiate(verdichteWolke, ShapeManager.instance.currentShape.transform.position, Quaternion.identity); // Neue Form instanziieren
        Camera.main.GetComponent<CameraController>().Follow(ShapeManager.instance.currentShape);

    }
}
