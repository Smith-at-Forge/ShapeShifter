using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class TimeTrackerV2 : MonoBehaviour
{
    public float timeTracker = 0;
    

    void Update()
    {
      timeTracker += Time.deltaTime;  
    }

    void DisplayTime (float timeToDisplay)
    {
        
    }
}
