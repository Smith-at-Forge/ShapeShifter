using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Level1 : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("StartLevel1");
    }
    
}
