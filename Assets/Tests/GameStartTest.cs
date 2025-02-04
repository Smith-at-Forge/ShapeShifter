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
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("SceneHabibStartLevel1");
        GameObject player = GameObject.Find("ShapeManager");
        Assert.IsNotNull(player, "Spieler-Objekt wurde nicht gefunden!");

        Assert.AreEqual(player.activeSelf, true, "Spiel-Objekt ist nicht aktiv!");

        yield break;
    }
}
