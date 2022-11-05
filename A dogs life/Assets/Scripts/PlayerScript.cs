using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("Movement")]
    public GameObject cameraFollow;
    public float speed;
    Vector3 movement;
    Vector3 rotation;
    Rigidbody playerRB;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //apply rotation
        if (Input.GetButton("Walk"))
        {
            rotation.y = cameraFollow.GetComponent<CameraScript>().rotation.y;
            transform.eulerAngles = rotation;
        }
    }

    void FixedUpdate()
    {
        //movement
        movement.z = Input.GetAxis("Vertical");
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 moveVector = transform.TransformDirection(movement) * speed * Time.deltaTime;
        playerRB.velocity = new Vector3(moveVector.x, playerRB.velocity.y, moveVector.z);
        Debug.Log(playerRB.velocity);
    }
}
