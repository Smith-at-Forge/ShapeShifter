using UnityEngine;

public class PlayerWaterCheck : MonoBehaviour
{
    private bool isInWater = false;
    [SerializeField] 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Water")
        {
            isInWater = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Water")
        {
            isInWater = false;
        }
    }

    

    public bool inWater()
    {
        return isInWater;
    }
}
