using UnityEngine;

public class PausenMenue : MonoBehaviour
{
    public GameObject pausenMenueUI;
    private bool isPaused = false;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pausenMenueUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pausenMenueUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    
}
