using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerMovementTest
{
    //// A Test behaves as an ordinary method
    //[Test]
    //public void PlayerMovementTestSimplePasses()
    //{
    //    // Use the Assert class to test conditions
    //}

    //// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    //// `yield return null;` to skip a frame.
    //[UnityTest]
    //public IEnumerator PlayerMovementTestWithEnumeratorPasses()
    //{
    //    // Use the Assert class to test conditions.
    //    // Use yield to skip a frame.
    //    yield return null;
    //}

    //private GameObject _testGameObject;
    //private PlayerController _playerController;
    //private Rigidbody2D _rigidbody2;

    //[SetUp]
    //public void SetUp()
    //{
    //    _testGameObject = new GameObject();
    //    _rigidbody2 = _testGameObject.AddComponent<Rigidbody2D>();
    //    _playerController = _testGameObject.AddComponent<PlayerController>();
    //}

    //[TearDown]
    //public void Teardown()
    //{
    //    Object.Destroy(_testGameObject);
    //}

    //[UnityTest]
    //public IEnumerator PlayerMovesRight()
    //{
    //    _playerController.Move();
    //    yield return new WaitForFixedUpdate();
    //    Assert.Greater(_rigidbody2.linearVelocity.x, 0, "Player should move right");
    //}

    //[UnityTest]
    //public IEnumerator PlayerMovesLeft()
    //{
    //    _playerController.Move();
    //    yield return new WaitForFixedUpdate();
    //    Assert.Less(_rigidbody2.linearVelocity.x, 0, "Player should move left");
    //}

    //[UnityTest]
    //public IEnumerator PlayerStopsMoving()
    //{
    //    _playerController.Move();
    //    yield return new WaitForFixedUpdate();
    //    Assert.AreEqual(0, _rigidbody2.linearVelocity.magnitude, "Player should stop moving");
    //}
}
