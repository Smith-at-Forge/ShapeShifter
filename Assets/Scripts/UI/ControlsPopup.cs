using UnityEngine;
using UnityEngine.UI;

public class ControlsPopup : MonoBehaviour
{
    // Ziehe hier im Inspektor dein UI-Panel (das den Text enthält) rein.
    public GameObject controlsPanel;

    void Start()
    {
        // Beim Start das Panel anzeigen
        if (controlsPanel != null)
        {
            controlsPanel.SetActive(true);
        }
    }

    void Update()
    {
        // Überprüfe, ob die linke oder rechte Pfeiltaste gedrückt wurde
        if (Input.anyKeyDown)
        {
            // Verstecke das Panel
            if (controlsPanel != null)
            {
                controlsPanel.SetActive(false);
            }
        }
    }
}
