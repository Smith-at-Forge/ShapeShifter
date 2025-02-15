using UnityEditor.Rendering;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public bool LevelOver = false;
    [SerializeField] 

    private void Update()
    {
        if(LevelOver)
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            LevelOver = true;
        }
    }
}
