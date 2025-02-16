using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBackgroundController : MonoBehaviour
{
    private float length, startPos;
    public GameObject cam;
    public float parallexEffect; 

    void Start() 
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x * transform.localScale.x;

        Debug.Log("Length: " + length);
    }
void FixedUpdate()
{
    float distance = cam.transform.position.x * parallexEffect;
    transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

    // Check against the *actual* background position, not a calculated temp value.
    if (transform.position.x > startPos + length)
    {
        startPos += length;
    }
    else if (transform.position.x < startPos - length)
    {
        startPos -= length;
    }
}

}
