using UnityEngine;

public class Counter : MonoBehaviour
{
    public int counterShapesShiftedLevel;
    public int counterShapesShiftedTotal;


    private void Awake()
    {
        Debug.Log("Level: " + counterShapesShiftedLevel + " " + "Game: " + counterShapesShiftedTotal);
    }

    public void IncrementShapeShift()
    {
        counterShapesShiftedLevel += 1;
        counterShapesShiftedTotal += 1;
        Debug.Log("Shift + 1");
    }
}
