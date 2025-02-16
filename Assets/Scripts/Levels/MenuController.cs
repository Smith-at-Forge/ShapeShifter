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
        Time.timeScale = 1f;
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }

    public void Level3()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }

    public void Level4()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }

    public void Level5()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }
    public void Level6()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }
    public void Level7()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }
    public void Level8()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }
    public void Level9()
    {
        SceneManager.LoadScene(9);
        Time.timeScale = 1f;
    }
    public void Level10()
    {
        SceneManager.LoadScene(10);
        Time.timeScale = 1f;
    }
    public void Exit()
    {
        Debug.Log("Spiele beendet über Menü");
        Application.Quit();
        
    }
    
    
}
