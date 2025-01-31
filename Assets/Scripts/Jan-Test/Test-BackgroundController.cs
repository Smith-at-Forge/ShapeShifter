using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private float startPos;
    public GameObject cam;
    public float parallexEffect; 

    void Start() 
    {

    float distance = cam.transform.position.x * paralexEffect; // 0 = move with cam -- 1 = won't move at all -- 0.5 = half

    transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
    }

}
