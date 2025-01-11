using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    public GameObject ShapeManager;

    // lebensanzeige
    public int leben;
    public Text lebenText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lebenText.text = leben.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        //Leben abziehen
        leben = leben - 1;

        //Lebensanzeige aktualisieren
        lebenText.text = leben.ToString();

        //Überprüfen ob Speler noch Leben hat
        if(leben > 0)
        {
            //falls ja -> Respawn
        }
        else
        {
            //falss nein -> Spielende
        }

    }
}
