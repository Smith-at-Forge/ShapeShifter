using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
   
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
    }

    public void Level3()
    {
        SceneManager.LoadScene(3);
    }

    public void Level4()
    {
        SceneManager.LoadScene(4);
    }

    public void Level5()
    {
        SceneManager.LoadScene(5);
    }
    public void Level6()
    {
        SceneManager.LoadSceneAsync("Level 6");
    }
    public void Level7()
    {
        SceneManager.LoadSceneAsync("Level 7");
    }
    public void Level8()
    {
        SceneManager.LoadSceneAsync("Level 8");
    }
    public void Level9()
    {
        SceneManager.LoadSceneAsync("Level 9");
    }
    public void Level10()
    {
        SceneManager.LoadSceneAsync("Level 10");
    }
    public void Exit()
    {
        Application.Quit();
    }
    
    
}
