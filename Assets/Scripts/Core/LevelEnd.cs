using UnityEditor.Rendering;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public bool levelAbgeschlossen = false;
    UIManager uiman;


    private void Update()
    {
        
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
