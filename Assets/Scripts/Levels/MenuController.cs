using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    //[Header("Level To Load")]
    //public string _newGameLevel;
    //private string levelToLoad;
    public void Level1()
    {
       SceneManager.LoadSceneAsync("Level 1");
    }

    public void Level2()
    {
        SceneManager.LoadSceneAsync("Level 2");
    }

    public void Level3()
    {
        SceneManager.LoadSceneAsync("Level 3");
    }

    public void Level4()
    {
        SceneManager.LoadSceneAsync("Level 4");
    }

    public void Level5()
    {
        SceneManager.LoadSceneAsync("Level 5");
    }
    public void Exit()
    {
        Application.Quit();
    }
    
}
