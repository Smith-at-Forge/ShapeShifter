using UnityEngine;
using UnityEngine.UI;

public class ControlsPopup : MonoBehaviour
{
    // Ziehe hier im Inspektor dein UI-Panel (das den Text enthält) rein.
    [SerializeField] private GameObject controlsPanel1;
    [SerializeField] private GameObject controlsPanel2;

    private void Awake()
    {
        controlsPanel1.SetActive(true);
        controlsPanel2.SetActive(false);
    }

    void Update()
    {
        // Überprüfe, ob die linke oder rechte Pfeiltaste gedrückt wurde
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Taste gedrückt");
            controlsPanel1.SetActive(false);
            controlsPanel2.SetActive(true);
        }

    }
}