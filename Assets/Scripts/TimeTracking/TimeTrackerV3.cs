using UnityEngine;
using TMPro;

public class TimeTrackerV3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeTracker;

    void Update()
    {
      timeTracker.text += Time.deltaTime;  
    }
}
