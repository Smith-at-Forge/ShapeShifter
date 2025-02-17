using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private float length, startPos;
    public GameObject cam;
    public float parallexEffect; 

    void Start() 
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x * transform.localScale.x;
    }
void FixedUpdate()
{
    float distance = cam.transform.position.x * parallexEffect;
    transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
}

}
