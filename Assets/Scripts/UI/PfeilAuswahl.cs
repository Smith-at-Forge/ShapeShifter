using Unity.Multiplayer.Center.Common.Analytics;
using UnityEngine;
using UnityEngine.UI;

public class PfeilAuswahl : MonoBehaviour
{
    [SerializeField] private RectTransform[] options;
    [SerializeField] private AudioClip changeSound;
    [SerializeField] private AudioClip interactSound;
    private RectTransform rect;
    private int currentPosition;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    private void Update()
    {
        // Aendert Pfeilposition
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            ChangePosition(-1);
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            ChangePosition(1);

        // Interaktion
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.KeypadEnter))
            Interact();
    }

    private void Interact()
    {
        // SoundManager.instace.PlaySound(interactSound);

        // Acces button
        options[currentPosition].GetComponent<Button>().onClick.Invoke();
    }

    private void ChangePosition(int _change)
    {
        currentPosition += _change;

        if(_change != 0)
            // SoundManager.instance.PlaySound(changeSound);

        if (currentPosition < 0)
            currentPosition = options.Length -1;
        else if (currentPosition > options.Length - 1)
            currentPosition = 0;

        // Setzt die Y Position des Feuerballs auf gewaehlte Option
        rect.position = new Vector3(rect.position.x, options[currentPosition].position.y, 0);
    }
}
