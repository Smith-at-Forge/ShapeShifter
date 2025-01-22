using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GameStartTest
{
    [UnityTest]
    public IEnumerator GameStartTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("StartLevel1");
        yield break;
    }
}
