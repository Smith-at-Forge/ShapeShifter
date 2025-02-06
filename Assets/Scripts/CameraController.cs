using UnityEngine;

public class CameraController : MonoBehaviour
{
    //[SerializeField] private float speed;
    private Vector3 velocity = Vector3.zero;

    // [SerializeField] private bool cameraVertikal = false;

    //Follow _player
    [SerializeField] private Transform player;

    [SerializeField] private float aheadDistanceHor;
    [SerializeField] private float cameraSpeedHor;
    private float lookAheadHor;

    [SerializeField] private float aheadDistanceVer;
    [SerializeField] private float cameraSpeedVer;
    private float lookAheadVer;

    private void LateUpdate() // LateUpdate
    {
        // Follow _player Horizontal
        transform.position = new Vector3(player.position.x + lookAheadHor, player.position.y + lookAheadVer, transform.position.z);
        lookAheadHor = Mathf.Lerp(lookAheadHor, (aheadDistanceHor * player.localScale.x), Time.deltaTime * cameraSpeedHor);
        lookAheadVer = Mathf.Lerp(lookAheadVer, (aheadDistanceVer * player.localScale.y), Time.deltaTime * cameraSpeedVer);

        
        

    }
    public void Follow(GameObject _player)
    {
        player = _player.transform;
    }
}