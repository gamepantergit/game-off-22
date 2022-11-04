using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float sensitivity;

    Vector3 rotation;

    void Start()
    {
        rotation.x = 40;
    }
    void Update()
    {
        //camera
        rotation.y += Input.GetAxis("Mouse X") * sensitivity;
        transform.eulerAngles = rotation;
    }
}
