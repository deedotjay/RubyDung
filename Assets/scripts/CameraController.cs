using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera TargetCam;
    public float ScrollSpeed = 10;
    public float speed = 0.1f;

    void Start()
    {
        Debug.Log("CameraController Loaded!");
    }

    
    void Update()
    {
        if (TargetCam.orthographic)
        {
            TargetCam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        }
        else
        {
            TargetCam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * ScrollSpeed;
        }

        // handle inputs
        if (Input.GetKey(KeyCode.UpArrow))
        {
           transform.position += transform.right * speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += -transform.right * speed;
            
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
           transform.position += transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += -transform.forward * speed;
        }




        
    }
}
