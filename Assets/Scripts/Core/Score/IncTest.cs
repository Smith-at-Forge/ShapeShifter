using UnityEngine;

public class IncTest : MonoBehaviour
{

    public Counter counter;

    private void Awake()
    {
        if (counter == null)
        {
            Debug.LogError("Reference not set");
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            counter.IncrementShapeShift();
        }
    }
}
