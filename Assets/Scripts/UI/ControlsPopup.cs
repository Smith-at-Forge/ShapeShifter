using UnityEngine;
using UnityEngine.UI;

public class ControlsPopup : MonoBehaviour
{
    // Ziehe hier im Inspektor dein UI-Panel (das den Text enthält) rein.
    [SerializeField] private GameObject controlsPanel1;
    [SerializeField] private GameObject controlsPanel2;
	[SerializeField] private GameObject controlsPanel3;
	[SerializeField] private GameObject controlsPanel4;

	
	
	
    private void Awake()
    {
        controlsPanel1.SetActive(true);
        controlsPanel2.SetActive(false);
		controlsPanel3.SetActive(true);
		controlsPanel4.SetActive(true);

    }

    void Update()
    {
        // Überprüfe, ob A oder D gedrückt wurde
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Taste gedrückt");
            controlsPanel1.SetActive(false);
            controlsPanel2.SetActive(true);
			controlsPanel3.SetActive(true);
			controlsPanel4.SetActive(true);
        }

    }
}