using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public string targetTag;

    private bool triggered = false; // Flag to prevent multiple triggers

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered && other.CompareTag(targetTag))
        {
            triggered = true; // Set the flag to true

            if (cam1 != null && cam2 != null) // Check for null references
            {
                cam1.enabled = false;
                cam2.enabled = true;
                Debug.Log("Camera switched!"); // Optional: For debugging
            }
            else
            {
                Debug.LogError("CameraSwitcher: cam1 or cam2 is not assigned!");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Optional: Switch back when the object exits the trigger
        if (triggered && other.CompareTag(targetTag))
        {
            triggered = false;
            if (cam1 != null && cam2 != null)
            {
                cam2.enabled = false;
                cam1.enabled = true;
                Debug.Log("Camera switched back!"); // Optional: For debugging
            }
            else
            {
                Debug.LogError("CameraSwitcher: cam1 or cam2 is not assigned!");
            }
        }
    }
}