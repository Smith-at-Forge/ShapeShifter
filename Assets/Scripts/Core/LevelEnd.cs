//using UnityEditor.Rendering;
using UnityEngine;
//using UnityEngine.UI;

public class LevelEnd : MonoBehaviour
{
    public bool levelAbgeschlossen = false;
    public UIManager uiman;


    private void Update()
    {
        if (levelAbgeschlossen)
        {
            uiman.GetComponent<UIManager>().LevelWon();
            Debug.Log("Level Won via reaching Goal");
        }
        /*
        else
        {
            return;
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            levelAbgeschlossen = true;
            //uiman.LevelWon();
            //Debug.Log("Lvl won");
            //Time.timeScale = 0f;
        }
    }
}
