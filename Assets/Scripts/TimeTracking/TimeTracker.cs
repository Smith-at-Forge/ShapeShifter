using TMPro;
using UnityEngine;

public class TimeTracker : MonoBehaviour
{
    private float startTime;
    private bool timer_running;
    [SerializeField] TextMeshProUGUI timerText;

    void Update()
    {
        //
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Timer-Anfang"))
        {
            startTime = Time.time;
            timer_running = true;
            Debug.Log("Timer Started");
        }

        else if (other.CompareTag("Timer-Ende"))
        {
            float endTime = Time.time;
            float elapsedTime = endTime - startTime;
            timerText.text = elapsedTime.ToString();
            Debug.Log("Timer: " + endTime + " Seconds" + "       Elapsed time since timer started: " + elapsedTime + " Seconds");
        }
    }
}
