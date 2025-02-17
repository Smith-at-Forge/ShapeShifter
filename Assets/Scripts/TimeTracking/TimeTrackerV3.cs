using UnityEngine;
using TMPro;
using System.Threading;

public class TimeTrackerV3 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeTracker;
    //[SerializeField] TextMeshProUGUI timeTrackerHighScore;
    float timePassed;

    void Update()
    {
        timePassed += Time.deltaTime;
      
        int minuten = Mathf.FloorToInt(timePassed / 60f);
        int sekunden = Mathf.FloorToInt(timePassed % 60f);

        timeTracker.text = string.Format("{0:00}:{1:00}", minuten, sekunden);
        //timeTrackerHighScore.text = string.Format("{0:00}:{1:00}", minuten, sekunden);

    }
}
