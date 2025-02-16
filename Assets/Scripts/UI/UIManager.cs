using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private AudioClip gameOverSound;
    [SerializeField] private GameObject victoryScreenLevel;
    [SerializeField] private GameObject victoryScreenGame;
    //[SerializeField] private GameObject statistikSpielAll;
    //LevelEnd levelend;
    


    private void Awake()
    {
        gameOverScreen.SetActive(false);
        victoryScreenLevel.SetActive(false);
        victoryScreenGame.SetActive(false);
        //statistikSpielAll.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            LevelWon();
            //victoryScreenLevel.SetActive(true);
            Debug.Log("Message");
        }
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        SoundManager.instance.PlaySound(gameOverSound);
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        // Szene 0 laden mit dem Ansatz, dass das Hauptmenue Szene 0 ist
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void NextLevel()
    {
        //SceneManager.LoadScene(2);
        
        Scene currentScene = SceneManager.GetActiveScene();
        int currenIndex = currentScene.buildIndex;

        int nextIndex = currenIndex + 1;

        if(nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            victoryScreenGame.SetActive(true);
        }
        
    }

    public void LevelWon()
    {
        victoryScreenLevel.SetActive(true);
        Time.timeScale = 0f;
    }
}
